using managerStudent.Models;
using managerStudent.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managerStudent
{
    public partial class FormChinhSuaDiem : Form
    {
        private string maHS = "";
        private readonly HocSinhService _hocSinhService;
        private readonly EFDbContext _context;
        private ErrorProvider errorProvider;
        private int maMon = 0;
        private double DTB = 0;
        public FormChinhSuaDiem(string maHS, int maMon = 0)
        {
            this.maHS = maHS;
            this.maMon = maMon;
            InitializeComponent();
            _context = new EFDbContext();
            _hocSinhService = new HocSinhService(_context);
            errorProvider = new ErrorProvider();
        }

        private void FormChinhSuaDiem_Load(object sender, EventArgs e)
        {
            if (maMon != 0)
            {
                txtMonHoc.Enabled = false;
                using (var context = new EFDbContext())
                {
                    var diem = context.Diems
                                     .Include(d => d.MonHoc)  // Nạp thông tin từ bảng MonHoc
                                     .Include(d => d.HocSinh) // Nạp thông tin từ bảng HocSinh
                                     .Where(d => d.MaHS == maHS && d.MaMon == maMon)
                                     .FirstOrDefault();
                    txtMonHoc.Text = diem.MonHoc.TenMH;
                    txtDiemCKHK1.Text = diem.DiemCKHK1.ToString();
                    txtDiemCKHK2.Text = diem.DiemCKHK2.ToString();
                    txtDiemGKHK1.Text = diem.DiemGKHK1.ToString();
                    txtDiemGKHK2.Text = diem.DiemGKHK2.ToString();
                    lbPercentTiLeGK.Text = ((int)Math.Round(diem.MonHoc.TiLeGK * 100)).ToString(); // Lấy tỉ lệ % GK
                    lbPercentTiLeCK.Text = ((int)Math.Round(diem.MonHoc.TiLeCuoiKi * 100)).ToString(); // Lấy tỉ lệ % cuối kì
                    lbPercentTiLeHK1.Text = ((int)Math.Round(diem.MonHoc.TiLeHK1 * 100)).ToString(); // Lấy tỉ lệ % học kì 1
                    lbPercentTiLeHK2.Text = ((int)Math.Round(diem.MonHoc.TiLeHK2 * 100)).ToString(); // Lấy tỉ lệ % học kì 2
                    lbTen.Text = diem.HocSinh.HoTenHS.ToString();
                    lbMaHS.Text = diem.HocSinh.MaHS.ToString();
                }
            }

            txtDiemCKHK1.TextChanged += lbDiemTBTong_TextChanged;
            txtDiemGKHK1.TextChanged += lbDiemTBTong_TextChanged;
            txtDiemCKHK2.TextChanged += lbDiemTBTong_TextChanged;
            txtDiemGKHK2.TextChanged += lbDiemTBTong_TextChanged;

            txtDiemCKHK1.Validating += lbXepLoai_Validating;
            txtDiemGKHK1.Validating += lbXepLoai_Validating;
            txtDiemCKHK2.Validating += lbXepLoai_Validating;
            txtDiemGKHK2.Validating += lbXepLoai_Validating;
            CalculateAverage();
        }

        private void SetErrorAndFocusControl(TextBox textBox, string errorMessage)
        {
            if (!string.IsNullOrEmpty(errorMessage))
            {
                errorProvider.SetError(textBox, errorMessage);
                //textBox.Focus(); // Đặt focus vào TextBox hiện tại khi có lỗi
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu không có lỗi
            }
        }
        private void CalculateAverage()
        {
            if (IsValidInput(txtDiemCKHK1.Text) &&
                IsValidInput(txtDiemGKHK1.Text) &&
                IsValidInput(txtDiemCKHK2.Text) &&
                IsValidInput(txtDiemGKHK2.Text)
            )
            {

                double diemCKHK1 = double.Parse(string.IsNullOrEmpty(txtDiemCKHK1.Text) ? "0" : txtDiemCKHK1.Text);
                double diemGKHK1 = double.Parse(string.IsNullOrEmpty(txtDiemGKHK1.Text) ? "0" : txtDiemGKHK1.Text);
                double diemCKHK2 = double.Parse(string.IsNullOrEmpty(txtDiemCKHK2.Text) ? "0" : txtDiemCKHK2.Text);
                double diemGKHK2 = double.Parse(string.IsNullOrEmpty(txtDiemGKHK2.Text) ? "0" : txtDiemGKHK2.Text);

                //Normalize the weights(assuming tiLeCK and tiLeGK are percentages)
                double weightCK = double.Parse(lbPercentTiLeCK.Text) / 100;
                double weightGK = double.Parse(lbPercentTiLeGK.Text) / 100;
                double weightHK1 = double.Parse(lbPercentTiLeHK1.Text) / 100;
                double weightHK2 = double.Parse(lbPercentTiLeHK2.Text) / 100;

                //// Calculate the average score for each semester
                double avgHK1 = (diemCKHK1 * weightCK) + (diemGKHK1 * weightGK);
                double avgHK2 = (diemCKHK2 * weightCK) + (diemGKHK2 * weightGK);

                // Calculate the final average score
                double finalAverage = (avgHK1 * weightHK1) + (avgHK2 * weightHK2);

                lbDTBHK1.Text = Math.Round(avgHK1, 2).ToString();
                lbDTBHK2.Text = Math.Round(avgHK2, 2).ToString();
                lbDiemTBTong.Text = Math.Round(finalAverage, 2).ToString();
                this.DTB = Math.Round(finalAverage, 2);
                //Kiểm tra và thiết lập xếp loại
                if (finalAverage >= 8)
                {
                    lbXepLoai.Text = "Giỏi";
                    lbtextDTBTong.ForeColor = Color.Green;
                    lbTextXepLoai.ForeColor = Color.Green;
                    lbXepLoai.ForeColor = Color.Green;
                    lbDiemTBTong.ForeColor = Color.Green;
                }
                else if (finalAverage >= 6.5)
                {
                    lbXepLoai.Text = "Khá";
                    lbtextDTBTong.ForeColor = Color.Green;
                    lbTextXepLoai.ForeColor = Color.Green;
                    lbXepLoai.ForeColor = Color.Green;
                    lbDiemTBTong.ForeColor = Color.Green;
                }
                else if (finalAverage >= 5)
                {
                    lbXepLoai.Text = "Trung bình";
                    lbtextDTBTong.ForeColor = Color.Red;
                    lbTextXepLoai.ForeColor = Color.Red;
                    lbDiemTBTong.ForeColor = Color.Red;
                    lbXepLoai.ForeColor = Color.Red;
                }
                else
                {
                    lbXepLoai.Text = "Yếu";
                    lbtextDTBTong.ForeColor = Color.Red;
                    lbTextXepLoai.ForeColor = Color.Red;
                    lbDiemTBTong.ForeColor = Color.Red;
                    lbXepLoai.ForeColor = Color.Red;
                }
            }
            else
            {
                lbDTBHK2.Text = "N/A";
                lbDTBHK2.Text = "N/A";
                lbDiemTBTong.Text = "N/A";
                lbXepLoai.Text = "N/A";
            }
        }

        private bool IsValidInput(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                text = "0";
            }

            if (double.TryParse(text, out double value))
            {
                return value >= 0 && value <= 10;
            }

            return false;
        }

        private void lbDiemTBTong_Click(object sender, EventArgs e)
        {

        }

        private void lbDiemTBTong_TextChanged(object sender, EventArgs e)
        {
            CalculateAverage();
        }

        private void lbXepLoai_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!IsValidInput(textBox.Text))
            {
                e.Cancel = true; // Ngăn chặn chuyển focus nếu có lỗi nhập liệu
                SetErrorAndFocusControl(textBox, "Invalid input. Please enter a number between 0 and 10.");
            }
            else
            {
                SetErrorAndFocusControl(textBox, ""); // Xóa thông báo lỗi nếu không có lỗi
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                // Tìm đối tượng Diem cần cập nhật
                var diem = context.Diems
                                 .FirstOrDefault(d => d.MaHS == maHS && d.MaMon == maMon);

                if (diem != null)
                {
                    // Cập nhật các trường dữ liệu của đối tượng Diem
                    diem.DiemCKHK1 = decimal.Parse(string.IsNullOrEmpty(txtDiemCKHK1.Text) ? "0" : txtDiemCKHK1.Text);
                    diem.DiemCKHK2 = decimal.Parse(string.IsNullOrEmpty(txtDiemCKHK2.Text) ? "0" : txtDiemCKHK2.Text);
                    diem.DiemGKHK1 = decimal.Parse(string.IsNullOrEmpty(txtDiemGKHK1.Text) ? "0" : txtDiemGKHK1.Text);
                    diem.DiemGKHK2 = decimal.Parse(string.IsNullOrEmpty(txtDiemGKHK2.Text) ? "0" : txtDiemGKHK2.Text);
                    diem.DTB = decimal.Parse(lbDiemTBTong.Text);
                    diem.XepLoai = lbXepLoai.Text;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    int recordsAffected = context.SaveChanges();
                    if (recordsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được lưu vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}

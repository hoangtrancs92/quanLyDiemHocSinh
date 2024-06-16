using managerStudent.Models;
using managerStudent.Services;
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
    public partial class ThemSuaDiem : Form
    {
        private string maHS = "";
        private readonly HocSinhService _hocSinhService;
        private readonly EFDbContext _context;
        private ErrorProvider errorProvider;
        public ThemSuaDiem(string maHS, int maMon = 0)
        {
            this.maHS = maHS;
            InitializeComponent();
            _context = new EFDbContext();
            _hocSinhService = new HocSinhService(_context);
            errorProvider = new ErrorProvider();
        }

        private void ThemSuaDiem_Load(object sender, EventArgs e)
        {
            lbMaHS.Text = _hocSinhService.GetHocSinhById(maHS).MaHS;
            lbTen.Text = _hocSinhService.GetHocSinhById(maHS).HoTenHS;
            loadTenMonHoc();

            txtDiemCKHK1.TextChanged += lbDTB_TextChanged;
            txtDiemGKHK1.TextChanged += lbDTB_TextChanged;
            txtDiemCKHK2.TextChanged += lbDTB_TextChanged;
            txtDiemGKHK2.TextChanged += lbDTB_TextChanged;

            txtDiemCKHK1.Validating += lbXepLoai_Validating;
            txtDiemGKHK1.Validating += lbXepLoai_Validating;
            txtDiemCKHK2.Validating += lbXepLoai_Validating;
            txtDiemGKHK2.Validating += lbXepLoai_Validating;
        }

        private void loadTenMonHoc()
        {
            using (var context = new EFDbContext())
            {
                var monhocAll = context.MonHocs
                .Where(mh => !context.Diems.Any(d => d.MaMon == mh.MaMon && d.MaHS == maHS))
                .ToList();

                comboBox1.DataSource = monhocAll;
                comboBox1.DisplayMember = "TenMH";
                comboBox1.ValueMember = "MaMon";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                var diem = new Diem
                {
                    MaHS = maHS,
                    MaMon = (int)comboBox1.SelectedValue,
                    DiemGKHK1 = decimal.Parse(txtDiemGKHK1.Text),
                    DiemCKHK1 = decimal.Parse(txtDiemCKHK1.Text),
                    DiemGKHK2 = decimal.Parse(txtDiemGKHK2.Text),
                    DiemCKHK2 = decimal.Parse(txtDiemCKHK2.Text),
                    DTB = decimal.Parse(lbDiemTBTong.Text),
                    XepLoai = lbXepLoai.Text

                };
                int rowsAffected = 0;

                context.Diems.Add(diem);
                rowsAffected = context.SaveChanges();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lưu điểm thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu điểm không thành công. Vui lòng thử lại!");
                }
            }
        }

        private void lbDTB_TextChanged(object sender, EventArgs e)
        {
            CalculateAverage();
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
                lbDTBHK1.Text = "N/A";
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

        private void lbDTB_Click(object sender, EventArgs e)
        {

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

        private void lbDTB_Validated(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Xử lý sau khi đã xác nhận tính hợp lệ của dữ liệu
            errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu có
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

        private void cbbTiLeGK_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cbbTiLeHK1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbDiemTBTong_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             // Thay thế bằng MaMon cụ thể cần lấy tỉ lệ
            using (var context = new EFDbContext())
            {
                var monhocAll = context.MonHocs
                    .Where(mh => !context.Diems.Any(d => d.MaMon == mh.MaMon && d.MaHS == maHS))
                    .ToList();

                comboBox1.DataSource = monhocAll;
                comboBox1.DisplayMember = "TenMH";
                comboBox1.ValueMember = "MaMon";
                int maMon = (int)comboBox1.SelectedValue;
                var monhoc = context.MonHocs
                .Where(mh => mh.MaMon == maMon)
                .FirstOrDefault(); // Lấy môn học với MaMon cụ thể

                if (monhoc != null)
                {
                    lbPercentTiLeGK.Text = ((int)Math.Round(monhoc.TiLeGK * 100)).ToString(); // Lấy tỉ lệ % GK
                    lbPercentTiLeCK.Text= ((int)Math.Round(monhoc.TiLeCuoiKi*100)).ToString(); // Lấy tỉ lệ % cuối kì
                    lbPercentTiLeHK1.Text = ((int)Math.Round(monhoc.TiLeHK1 * 100)).ToString(); // Lấy tỉ lệ % học kì 1
                    lbPercentTiLeHK2.Text = ((int)Math.Round(monhoc.TiLeHK2 * 100)).ToString(); // Lấy tỉ lệ % học kì 2

                    // Sử dụng các giá trị tiLeGK, tiLeCuoiKi, tiLeHK1, tiLeHK2 theo nhu cầu của bạn
                }
                else
                {
                    // Xử lý khi không tìm thấy môn học với MaMon cụ thể
                }
            }
                
        }
    }
}

using managerStudent.Models;
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
        public ThemSuaDiem()
        {
            InitializeComponent();
        }

        private void ThemSuaDiem_Load(object sender, EventArgs e)
        {
            loadTenMonHoc();
        }

        private void loadTenMonHoc()
        {
            using (var context = new EFDbContext())
            {
                var monhocAll = context.MonHocs.ToList();

                monhocAll.Insert(0, new MonHoc { MaMon = 0, TenMH = "Tất cả" });
                comboBox1.DataSource = monhocAll;
                comboBox1.DisplayMember = "TenMH";
                comboBox1.ValueMember = "MaMon";
            }
        }
    }
}

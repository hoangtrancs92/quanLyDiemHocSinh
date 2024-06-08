using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class Diem
    {
        // Khóa ngoại
        [Key, Column(Order = 0)]
        public string MaHS { get; set; }

        [Key, Column(Order = 1)]
        public int MaMon { get; set; }

        public decimal DiemGKHK1 { get; set; }
        public decimal DiemCKHK1 { get; set; }
        public decimal DiemGKHK2 { get; set; }
        public decimal DiemCKHK2 { get; set; }
        public decimal DTB { get; set; }

        [StringLength(100)]
        public string XepLoai { get; set; }

        // Navigation properties
        public HocSinh HocSinh { get; set; }
        public MonHoc MonHoc { get; set; }
    }
}

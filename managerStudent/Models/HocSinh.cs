using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class HocSinh
    {
        [Key]
        [StringLength(20)]
        public string MaHS { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(100)]
        public string HoTenHS { get; set; }

        public DateTime NgSinh { get; set; }

        [StringLength(100)]
        public string GioiTinh { get; set; }

        [StringLength(255)]
        public string NoiSinh { get; set; }

        [StringLength(50)]
        public string DanToc { get; set; }

        // Khóa ngoại
        public int MaLop { get; set; }
        public Lop Lop { get; set; }

        // Navigation property
        public ICollection<Diem> Diems { get; set; }

        // Mã hóa mật khẩu trước khi thêm dữ liệu vào migration
        public static string HashPassword(string password)
        {
            // Đây là nơi bạn thực hiện mã hóa mật khẩu, dưới đây là một ví dụ đơn giản
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class QuanTri
    {
        [Key]
        public int QuanTriID { get; set; }

        [StringLength(100)]
        public string TenDangNhap { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }
        public static string HashPassword(string password)
        {
            // Đây là nơi bạn thực hiện mã hóa mật khẩu, dưới đây là một ví dụ đơn giản
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}

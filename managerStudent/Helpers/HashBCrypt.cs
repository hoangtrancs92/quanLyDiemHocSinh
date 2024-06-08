using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Helpers
{
    internal class HashBCrypt
    {
        // Mã hóa mật khẩu trước khi thêm dữ liệu vào migration
        public static string HashPassword(string password)
        {
            // Đây là nơi bạn thực hiện mã hóa mật khẩu, dưới đây là một ví dụ đơn giản
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}

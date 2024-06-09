using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class Khoi
    {
        [Key]
        public int MaKhoi { get; set; }
        public string TenKhoi { get; set; }

        // Navigation property
        public ICollection<Lop> Lops { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class Lop
    {
        [Key]
        public int MaLop { get; set; }

        [StringLength(100)]
        public string TenLop { get; set; }

        [StringLength(100)]
        public string NamHoc { get; set; }

        // Navigation property
        public ICollection<HocSinh> HocSinhs { get; set; }
    }
}

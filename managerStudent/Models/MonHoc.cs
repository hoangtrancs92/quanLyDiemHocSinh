using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Models
{
    internal class MonHoc
    {
        [Key]
        public int MaMon { get; set; }

        [StringLength(100)]
        public string TenMH { get; set; }

        public float HeSoMon { get; set; }
        public float TiLeGK { get; set; }
        public float TiLeCuoiKi { get; set; }
        public float TiLeHK1 { get; set; }
        public float TiLeHK2 { get; set; }

        [StringLength(100)]
        public string Khoi { get; set; }

        // Navigation property
        public ICollection<Diem> Diems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX.Models
{
    [Table("XNLDH")]
    public class DataXNLDH
    {
        public int ID { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [StringLength(30)]
        public string TenNL { get; set; }
        [Required]
        public int Soluongxuat { get; set; }
        [Required]
        public DateTime Ngaygioxuat { get; set; }
        [Required]
        public int KHThangNam { get; set; }
        [Required]
        [StringLength(30)]
        public string Index { get; set; }
        [Required]
        public DateTime Ngaydung { get; set; }

    }
}

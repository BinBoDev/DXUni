using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX.Models
{
    [Table("SPDH")]
    public class DataSPDH
    {
        public int Id { get; set; }
        public string MaDH { get; set; }
        public string MaKHDH { get; set; }
        public string MaKHLR { get; set; }
        public int CodeJK { get; set; }
        public int Code { get; set; }
        public string Chungloaichinh { get; set; }
        public string TenSP { get; set; }
        public string Mau { get; set; }
        public string NhomDH { get; set; }
        public int ThangKH { get; set; }
        public int NamKH { get; set; }
        public int KHLan { get; set; }
        public int SoKHDH { get; set; }
        public DateTime NgayDH { get; set; }
        public string SoloDH { get; set; }
        public int SoluongDHChithi { get; set; }
        public int SoluongDH { get; set; }
        public string Ghichu { get; set; }
        public int PPHuyDH { get; set; }
        public int PPSuaDH { get; set; }
        public DateTime Thoidiemchithi { get; set; }
        public DateTime ThoidiemNK { get; set; }
        public int MucchayDH { get; set; }
        public int ButmeoDH { get; set; }
        public int NhanhongDH { get; set; }
        public int NhankhongcoDH { get; set; }
        public int BanmucDH { get; set; }
        public int BankhacDH { get; set; }
        public int BankeoDH { get; set; }
        public int BantocDH { get; set; }
        public int TuotnapDH { get; set; }
        public int BochongDH { get; set; }
        public int PhelieubutDH { get; set; }




    }
}

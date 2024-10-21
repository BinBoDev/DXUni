using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX.Models
{
    [Table("DataSP")]
    public class DataSP
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string MaKH { get; set; }
        [Required]
        [StringLength(30)]
        public string MaLoLR { get; set; }
        public int? CodeMPV { get; set; }
        [Required]
        public int CodeJK { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [StringLength(20)]
        public string Chungloai { get; set; }
        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }
        [Required]
        [StringLength(30)]
        public string Mau { get; set; }
        [Required]
        [StringLength(20)]
        public string Daychuyen { get; set; }
        [Required]
        [StringLength(20)]
        public string Tendaychuyen { get; set; }
        [Required]
        [StringLength(20)]
        public string NhomLR { get; set; }
        [Required]
        [Range(1, 12)]
        public int ThangKH { get; set; }
        [Required]
        public int NamKH { get; set; }
        [Required]
        public int KHLan { get; set; }
        [Required]
        public int SotheoKH { get; set; }
        public DateTime NgayLR { get; set; }
        [Required]
        [StringLength(20)]
        public string Solo { get; set; }
        [Required]
        public int SLLRChithi { get; set; }
        [Required]
        public int Soluongthuduoc { get; set; }
        public int? Soluonghuy { get; set; }
        public int? Soluongsua { get; set; }
        public int? PPTrenmay { get; set; }
        public int? SoluongmauQC { get; set; }
        [Required]
        public DateTime ThoigianStart { get; set; }
        [Required]
        public DateTime ThoigianFinish { get; set; }
        public decimal? ThoigiandungKH { get; set; }
        public decimal? Thoigianhaohut { get; set; }
        [Required]
        public decimal OEE { get; set; }
        [Required]
        public decimal Thoigianlamviectrenngay { get; set; }
        public decimal? Thoigianchaytai { get; set; }
        [Required]
        public decimal Thoigianhoatdongmay { get; set; }
        [Required]
        public decimal Thoigianchayrong { get; set; }
        [Required]
        public decimal Tylethanhpham { get; set; }
        [Required]
        public int Tocdodaychuyen { get; set; }
        public DateTime? Ngaydonghop { get; set; }
        public string? Solodonghop { get; set; }
        public int? Soluongdonghop { get; set; }
        public int? Huydonghop { get; set; }
        public int? Suadonghop { get; set; }
        public int? Phephamhuydonghop { get; set; }
        public int? Phephamsuadonghop { get; set; }
        public decimal? Nangxuatdonghop { get; set; }
        public int? Thoidiemchithi { get; set; }
        public DateTime? Thoidiemnhapkho { get; set; }
        public int? Bankhac { get; set; }
        public int? Banmuc { get; set; }
        public int? Botkhi {  get; set; }
        public int? Bantoc { get; set; }
        public int? Chaymuc { get; set; }
        public int? Hoduoi { get; set; }
        public int? Honap { get; set; }
        public int? Inhong { get; set; }
        public int? Thuathieubi { get; set; }
        public int? Khongnhannap { get; set; }
        public int? Lechthantruoc { get; set; }
        public int? MeomiengBody { get; set; }
        public int? Butmeo { get; set; }
        public int? Napkhongdap { get; set; }
        public int? Ngoidai { get; set; }
        public int? NgoiNG { get; set; }
        public int? Ngoingan { get; set; }
        public int? Ngoinguoc { get; set; }
        public int? Ngoixuoc { get; set; }
        public int? NhannapNG { get; set; }
        public int? PhephamdoNL { get; set; }
        public int? Shortduoi { get; set; }
        public int? Solohong { get; set; }
        public int? ThuathieuNL { get; set; }
        public int? Tuotnap { get; set; }
        public int? Tutmuc { get; set; }
        public int? Thaninhong { get; set; }
        public int? Ngoinghieng { get; set; }
        public int? Ngoiphinh { get; set; }
        public int? Banbui { get; set; }
        public int? Loilapghep { get; set; }
        public int? LoidoTH { get; set; }
        public int? Sutxuoc { get; set; }
        public int? Loikhac { get; set; }
        public int? Napban { get; set; }
        public int? Naproi { get; set; }
        public int? NhanPOSdut { get; set; }
        public int? Nhancotapvat { get; set; }
        public int? Xuocthan { get; set; }
        public int? Loiinfilm { get; set; }
        public int? Banbui202 { get; set; }
        public int? MucchayDH { get; set; }
        public int? ButmeoDH { get; set; }
        public int? NhanhongDH { get; set; }
        public int? NhankhongcoDH { get; set; }
        public int? BanmucDH { get; set; }
        public int? BankhacDH { get; set; }
        public int? BankeoDH { get; set; }
        public int? BantocDH { get; set; }
        public int? TuotnapDH { get; set; }
        public int? BochongDH { get; set; }
        public int? PhelieubutDH { get; set; }
        public string Ghichu { get; set; }
















    }
}

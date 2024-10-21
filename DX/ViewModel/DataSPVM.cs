using DX.Commands;
using DX.Models;
using DX.View;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DX.ViewModel
{
    public class DataSPVM : INotifyPropertyChanged
    {
        private  DXSP dbContext;
        public ObservableCollection<DataSP> DataSPs { get; private set; }
        public ICommand ImportDataCommand { get; set; }

        public DataSPVM()
        {
            dbContext = new DXSP();

            ImportDataCommand = new RelayCommand(ImportData);

        }

        private void ImportData(object? obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Tìm file";
            openFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Lấy đường dẫn file và hiển thị trong TextBox
                var filePath = openFileDialog.FileName;
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        //var dataSet = reader.AsDataSet();
                        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true // Sử dụng hàng đầu tiên làm hàng tiêu đề
                            }
                        });
                        var dataTable = dataSet.Tables[0];
                        foreach (DataRow row in dataTable.Rows)
                        {
                            try
                            {
                                var dataSP = new DataSP()
                                {
                                    MaKH = row["Ma KH"].ToString(),
                                    CodeMPV = row["Code (MPV)"].ToString(),
                                    MaLoLR = row["Ma lo LR"].ToString(),
                                    CodeJK = row["Code JK"] != DBNull.Value ? Convert.ToInt32(row["Code JK"]) : 0,
                                    Code = row["Code (7 so)"] != DBNull.Value ? Convert.ToInt32(row["Code (7 so)"]) : 0,
                                    Chungloai = row["Chung loai chinh"].ToString(),
                                    TenSP = row["Ten SP"].ToString(),
                                    Mau = row["Mau"].ToString(),
                                    Daychuyen = row["Day chuyen"].ToString(),
                                    Tendaychuyen = row["Ten day chuyen"].ToString(),
                                    NhomLR = row["Nhom LR"].ToString(),
                                    ThangKH = row["Thang KH"] != DBNull.Value ? Convert.ToInt32(row["Thang KH"]) : 0,
                                    NamKH = row["Nam KH"] != DBNull.Value ? Convert.ToInt32(row["Nam KH"]) : 0,
                                    KHLan = row["KH lan"] != DBNull.Value ? Convert.ToInt32(row["KH lan"]) : 0,
                                    SotheoKH = row["So theo Ke hoach"] != DBNull.Value ? Convert.ToInt32(row["So theo Ke hoach"]) : 0,
                                    //NgayLR = row["Ngay Lap Rap"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Ngay Lap Rap"]),
                                    NgayLR = row["Ngay Lap Rap"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Ngay Lap Rap"]),

                                    Solo = row["So lo"].ToString(),
                                    SLLRChithi = row["SLLR chi thi"] != DBNull.Value ? Convert.ToInt32(row["SLLR chi thi"]) : 0,
                                    Soluongthuduoc = row["So luong thu duoc"] != DBNull.Value ? Convert.ToInt32(row["So luong thu duoc"]) : 0,
                                    Soluonghuy = row["Huy"] != DBNull.Value ? Convert.ToInt32(row["Huy"]) : 0,
                                    Soluongsua = row["Sua"] != DBNull.Value ? Convert.ToInt32(row["Sua"]) : 0,
                                    PPTrenmay = row["PP tren may"] != DBNull.Value ? Convert.ToInt32(row["PP tren may"]) : 0,
                                    SoluongmauQC = row["So luong mau QC"] != DBNull.Value ? Convert.ToInt32(row["So luong mau QC"]) : 0,
                                    ThoigianStart = row["Thoi gian Start"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Thoi gian Start"]),
                                    ThoigianFinish = row["Thoi gian Finish"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Thoi gian Finish"]),
                                    ThoigiandungKH = row["Thoi gian dung KH"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian dung KH"]) : 0,
                                    Thoigianhaohut = row["Thoi gian hao hut"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian hao hut"]) : 0,
                                    OEE = row["OEE(%)"] != DBNull.Value ? Convert.ToDecimal(row["OEE(%)"]) : 0,
                                    Thoigianlamviectrenngay = row["Thoi gian lv/ngay"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian lv/ngay"]) : 0,
                                    Thoigianchaytai = row["Thoi gian chay tai (h)"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian chay tai (h)"]) : 0,
                                    Thoigianhoatdongmay = row["Thoi gian hoat dong may"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian hoat dong may"]) : 0,
                                    Thoigianchayrong = row["Thoi gian chay rong"] != DBNull.Value ? Convert.ToDecimal(row["Thoi gian chay rong"]) : 0,
                                    Tylethanhpham = row["Ty le thanh pham"] != DBNull.Value ? Convert.ToDecimal(row["Ty le thanh pham"]) : 0,
                                    Tocdodaychuyen = row["Toc do d/c"] != DBNull.Value ? Convert.ToInt32(row["Toc do d/c"]) : 0,
                                    Ngaydonghop = row["Ngay Dong hop"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Ngay Dong hop"]),
                                    Solodonghop = row["So lo dong hop"].ToString(),
                                    Soluongdonghop = row["So luong dong hop"] != DBNull.Value ? Convert.ToInt32(row["So luong dong hop"]) : 0,
                                    Huydonghop = row["Huy DH"] != DBNull.Value ? Convert.ToInt32(row["Huy DH"]) : 0,
                                    Suadonghop = row["Sua DH"] != DBNull.Value ? Convert.ToInt32(row["Sua DH"]) : 0,
                                    Phephamhuydonghop = row["PP huy DH"] != DBNull.Value ? Convert.ToInt32(row["PP huy DH"]) : 0,
                                    Phephamsuadonghop = row["PP sua DH"] != DBNull.Value ? Convert.ToInt32(row["PP sua DH"]) : 0,
                                    Nangxuatdonghop = row["Nang suat DH"] != DBNull.Value ? Convert.ToDecimal(row["Nang suat DH"]) : 0,
                                    Thoidiemchithi = row["Thoi diem chi thi"] != DBNull.Value ? Convert.ToInt32(row["Thoi diem chi thi"]) : 0,
                                    Thoidiemnhapkho = row["Thoi diem NK"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Thoi diem NK"]),
                                    Bankhac = row["Ban khac"] != DBNull.Value ? Convert.ToInt32(row["Ban khac"]) : 0,
                                    Banmuc = row["Ban muc"] != DBNull.Value ? Convert.ToInt32(row["Ban muc"]) : 0,
                                    Banthantruoc = row["Ban than truoc"] != DBNull.Value ? Convert.ToInt32(row["Ban than truoc"]) : 0,
                                    Botkhi = row["Bot khi"] != DBNull.Value ? Convert.ToInt32(row["Bot khi"]) : 0,
                                    Bantoc = row["Ban toc"] != DBNull.Value ? Convert.ToInt32(row["Ban toc"]) : 0,
                                    Chaymuc = row["Chay muc"] != DBNull.Value ? Convert.ToInt32(row["Chay muc"]) : 0,
                                    Hoduoi = row["Ho duoi"] != DBNull.Value ? Convert.ToInt32(row["Ho duoi"]) : 0,
                                    Honap = row["Ho nap"] != DBNull.Value ? Convert.ToInt32(row["Ho nap"]) : 0,
                                    Inhong = row["In hong"] != DBNull.Value ? Convert.ToInt32(row["In hong"]) : 0,
                                    Thuathieubi = row["Thua thieu bi"] != DBNull.Value ? Convert.ToInt32(row["Thua thieu bi"]) : 0,
                                    Khongnhannap = row["Khong nhan nap"] != DBNull.Value ? Convert.ToInt32(row["Khong nhan nap"]) : 0,
                                    Lechthantruoc = row["Lech than truoc"] != DBNull.Value ? Convert.ToInt32(row["Lech than truoc"]) : 0,
                                    MeomiengBody = row["Meo mieng body"] != DBNull.Value ? Convert.ToInt32(row["Meo mieng body"]) : 0,
                                    Butmeo = row["But meo"] != DBNull.Value ? Convert.ToInt32(row["But meo"]) : 0,
                                    Napkhongdap = row["Nap khong dap"] != DBNull.Value ? Convert.ToInt32(row["Nap khong dap"]) : 0,
                                    Ngoidai = row["Ngoi dai"] != DBNull.Value ? Convert.ToInt32(row["Ngoi dai"]) : 0,
                                    NgoiNG = row["Ngoi NG"] != DBNull.Value ? Convert.ToInt32(row["Ngoi NG"]) : 0,
                                    Ngoingan = row["Ngoi ngan"] != DBNull.Value ? Convert.ToInt32(row["Ngoi ngan"]) : 0,
                                    Ngoinguoc = row["Ngoi nguoc"] != DBNull.Value ? Convert.ToInt32(row["Ngoi nguoc"]) : 0,
                                    Ngoixuoc = row["Ngoi xuoc"] != DBNull.Value ? Convert.ToInt32(row["Ngoi xuoc"]) : 0,
                                    NhannapNG = row["Nhan nap NG"] != DBNull.Value ? Convert.ToInt32(row["Nhan nap NG"]) : 0,
                                    PhephamdoNL = row["PP do NL"] != DBNull.Value ? Convert.ToInt32(row["PP do NL"]) : 0,
                                    Shortduoi = row["Short duoi"] != DBNull.Value ? Convert.ToInt32(row["Short duoi"]) : 0,
                                    Solohong = row["So lo hong"] != DBNull.Value ? Convert.ToInt32(row["So lo hong"]) : 0,
                                    ThuathieuNL = row["Thua thieu NL"] != DBNull.Value ? Convert.ToInt32(row["Thua thieu NL"]) : 0,
                                    Tuotnap = row["Tuot nap"] != DBNull.Value ? Convert.ToInt32(row["Tuot nap"]) : 0,
                                    Tutmuc = row["Tut muc"] != DBNull.Value ? Convert.ToInt32(row["Tut muc"]) : 0,
                                    Thaninhong = row["Than in hong"] != DBNull.Value ? Convert.ToInt32(row["Than in hong"]) : 0,
                                    Ngoinghieng = row["Ngoi nghieng"] != DBNull.Value ? Convert.ToInt32(row["Ngoi nghieng"]) : 0,
                                    Ngoiphinh = row["Ngoi phinh"] != DBNull.Value ? Convert.ToInt32(row["Ngoi phinh"]) : 0,
                                    Banbui = row["Ban bui"] != DBNull.Value ? Convert.ToInt32(row["Ban bui"]) : 0,
                                    Loilapghep = row["Loi lap ghep"] != DBNull.Value ? Convert.ToInt32(row["Loi lap ghep"]) : 0,
                                    LoidoTH = row["Loi do TH"] != DBNull.Value ? Convert.ToInt32(row["Loi do TH"]) : 0,
                                    Sutxuoc = row["Sut xuoc"] != DBNull.Value ? Convert.ToInt32(row["Sut xuoc"]) : 0,
                                    Loikhac = row["Loi khac"] != DBNull.Value ? Convert.ToInt32(row["Loi khac"]) : 0,
                                    Napban = row["Nap ban"] != DBNull.Value ? Convert.ToInt32(row["Nap ban"]) : 0,
                                    Naproi = row["Nap roi"] != DBNull.Value ? Convert.ToInt32(row["Nap roi"]) : 0,
                                    NhanPOSdut = row["Nhan POS dut"] != DBNull.Value ? Convert.ToInt32(row["Nhan POS dut"]) : 0,
                                    Nhancotapvat = row["Nhan co tap vat"] != DBNull.Value ? Convert.ToInt32(row["Nhan co tap vat"]) : 0,
                                    Xuocthan = row["Xuoc than"] != DBNull.Value ? Convert.ToInt32(row["Xuoc than"]) : 0,
                                    Loiinfilm = row["Loi in phim"] != DBNull.Value ? Convert.ToInt32(row["Loi in phim"]) : 0,
                                    Banbui202 = row["Ban bui 202"] != DBNull.Value ? Convert.ToInt32(row["Ban bui 202"]) : 0,
                                    MucchayDH = row["Muc chay DH"] != DBNull.Value ? Convert.ToInt32(row["Muc chay DH"]) : 0,
                                    ButmeoDH = row["But meo DH"] != DBNull.Value ? Convert.ToInt32(row["But meo DH"]) : 0,
                                    NhanhongDH = row["Nhan hong DH"] != DBNull.Value ? Convert.ToInt32(row["Nhan hong DH"]) : 0,
                                    NhankhongcoDH = row["Nhan khong co DH"] != DBNull.Value ? Convert.ToInt32(row["Nhan khong co DH"]) : 0,
                                    BanmucDH = row["Ban muc DH"] != DBNull.Value ? Convert.ToInt32(row["Ban muc DH"]) : 0,
                                    BankhacDH = row["Ban khac DH"] != DBNull.Value ? Convert.ToInt32(row["Ban khac DH"]) : 0,
                                    BankeoDH = row["Ban keo DH"] != DBNull.Value ? Convert.ToInt32(row["Ban keo DH"]) : 0,
                                    BantocDH = row["Ban toc DH"] != DBNull.Value ? Convert.ToInt32(row["Ban toc DH"]) : 0,
                                    TuotnapDH = row["Tuot nap DH"] != DBNull.Value ? Convert.ToInt32(row["Tuot nap DH"]) : 0,
                                    BochongDH = row["Boc hong DH"] != DBNull.Value ? Convert.ToInt32(row["Boc hong DH"]) : 0,
                                    PhelieubutDH = row["Boc hong DH"] != DBNull.Value ? Convert.ToInt32(row["Boc hong DH"]) : 0,
                                    Ghichu = row["Ghi chu"].ToString()
                                };

                                dbContext.dataSPs.Add(dataSP);
                                

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                            
                        
                    }
                        try
                        {
                            // Thao tác lưu dữ liệu
                            dbContext.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            // Log thông tin chi tiết
                            Console.WriteLine("Error occurred: " + ex.InnerException?.Message);
                            // Thêm thông tin cụ thể từ dữ liệu
                        }
                        //dbContext.SaveChanges();
                    MessageBox.Show("Import Data thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //XuatNLs = new ObservableCollection<XuatNL>(dbContex.xuatNLs.ToList());
                }
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
}

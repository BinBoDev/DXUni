using DX.Commands;
using DX.Models;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private readonly DXSP dbContext;
        public ObservableCollection<DataSP> DataSPs { get; private set; }
        public ICommand ImportDataCommand { get;set; }

        public DataSPVM()
        {
            dbContext = new DXSP();
            ImportDataCommand = new RelayCommand(Import);

        }

        private void Import(object? obj)
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
                            var dataSP = new DataSP()
                            {
                                //CodeNL = row["Code NL"] != DBNull.Value ? Convert.ToInt32(row["Code NL"]) : throw new Exception("CodeNL không được trống"),
                                //TenNL = row["Ten NL"].ToString(),
                                //Soluongxuat = row["So luong xuat"] != DBNull.Value ? Convert.ToInt32(row["So luong xuat"]) : 0,
                                //Ngaygioxuatthucte = Convert.ToDateTime(row["Ngay gio xuat thuc te"]),
                                //KehoachThangNam = row["KH thang nam"].ToString(),
                                //Index = row["Index"].ToString(),
                                //Xuatkhosanxuatngay = row["Xuat kho cho SX ngay"] != DBNull.Value ? row["Xuat kho cho SX ngay"].ToString() : null

                            };
                            dbContext.dataSPs.Add(dataSP);
                        }
                        dbContext.SaveChanges();
                        MessageBox.Show("Import Data thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //XuatNLs = new ObservableCollection<XuatNL>(dbContex.xuatNLs.ToList());
                    }
                }
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

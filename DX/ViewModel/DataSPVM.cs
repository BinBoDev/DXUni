using DX.Commands;
using DX.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

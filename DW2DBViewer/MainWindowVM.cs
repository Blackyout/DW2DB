using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DW2DBViewer.Tabs;

namespace DW2DBViewer
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            AllDigimonsVM = new AllDigimonsVM();
            DigivolveDNAVM = new DigivolveDNAVM();
        }

        public AllDigimonsVM AllDigimonsVM { get; set; }
        public DigivolveDNAVM DigivolveDNAVM { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

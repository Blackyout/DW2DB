using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DW2DB.Annotations;
using DW2DB.Tabs;

namespace DW2DB
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        public MainWindowVM()
        {
            DBLoader.Load();
            AllDigimonsVM = new AllDigimonsVM();
            DigivolveDNAVM = new DigivolveDNAVM();
        }

        public AllDigimonsVM AllDigimonsVM { get; set; }
        public DigivolveDNAVM DigivolveDNAVM { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

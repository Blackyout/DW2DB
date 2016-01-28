using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DataBase;
using DW2DBViewer.Tabs;
using Gat.Controls;

namespace DW2DBViewer
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            AllDigimonsVM = new AllDigimonsVM();
            DigivolveDNAVM = new DigivolveDNAVM();
            DigivolveDNAVM.DigimonClicked += AllDigimonsVM.DigimonClicked;
            ShowAboutCmd = new DelegateCommand(DoShowAbout);
        }

        private void DoShowAbout()
        {
            var about = new About();

            about.Title = "Digimon World 2 База данных";
            about.Description = "Помогалка в игре DW2";
            about.Hyperlink =  new Uri("http://www.digimonworld.ru");
            about.HyperlinkText = "http://www.digimonworld.ru";
            about.PublisherLogo = null;
            about.Version = "1.0.0";
            about.AdditionalNotes =
                "Программирование: Мисюрин Артём, drdoomenator@gmail.com";
            about.Show();
            
        }

        public AllDigimonsVM AllDigimonsVM { get; set; }
        public DigivolveDNAVM DigivolveDNAVM { get; set; }

        public ICommand ShowAboutCmd { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

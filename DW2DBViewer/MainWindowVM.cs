using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
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
            DBLoader.LoadStatic();
        }

        private void DoShowAbout()
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/DW2DBViewer;component/Resources/icon.png");
            logo.EndInit();


            var about = new About();

            about.ApplicationLogo = logo; 
            switch (App.Language.Name)
            {
                case "ru-RU":
                    about.Title = "Digimon World 2 База данных";
                    about.Description = "Помогалка в игре DW2";
                    about.Hyperlink = new Uri("https://github.com/drdoomenator/DW2DB");
                    about.HyperlinkText = "https://github.com/drdoomenator/DW2DB";
                    about.PublisherLogo = null;
                    about.Version = "1.0.0";
                    about.AdditionalNotes =
                        "Программирование: Мисюрин Артём, drdoomenator@gmail.com, специально для digimonworld.ru";
                    break;
                default:
                    about.Title = "Digimon World 2 DataBase";
                    about.Description = "Helper for DW2";
                    about.Hyperlink = new Uri("https://github.com/drdoomenator/DW2DB");
                    about.HyperlinkText = "https://github.com/drdoomenator/DW2DB";
                    about.PublisherLogo = null;
                    about.Version = "1.0.0";
                    about.AdditionalNotes =
                        "Programming: Misurin Artem, drdoomenator@gmail.com, for digimonworld.ru";
                    break;
            }
            
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

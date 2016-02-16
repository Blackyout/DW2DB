using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media.Imaging;
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

        public AllDigimonsVM AllDigimonsVM { get; set; }
        public DigivolveDNAVM DigivolveDNAVM { get; set; }

        public ICommand ShowAboutCmd { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void DoShowAbout()
        {
            var logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/DW2DBViewer;component/Resources/icon.png");
            logo.EndInit();


            var version =  (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                           ? System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                           : "!версии нет!";

            var about = new About();

            about.ApplicationLogo = logo;
            about.Version = version;
            switch (App.Language.Name)
            {
                case "ru-RU":
                    about.Title = "Digimon World 2 База данных";
                    about.Description = "Помогалка в игре DW2";
                    about.Hyperlink = new Uri("https://github.com/drdoomenator/DW2DB");
                    about.HyperlinkText = "https://github.com/drdoomenator/DW2DB";
                    about.PublisherLogo = null;
                    about.AdditionalNotes =
                        "Программирование: Мисюрин Артём, drdoomenator@gmail.com, специально для digimonworld.ru";
                    break;
                default:
                    about.Title = "Digimon World 2 DataBase";
                    about.Description = "Helper for DW2";
                    about.Hyperlink = new Uri("https://github.com/drdoomenator/DW2DB");
                    about.HyperlinkText = "https://github.com/drdoomenator/DW2DB";
                    about.PublisherLogo = null;
                    about.AdditionalNotes =
                        "Programming: Misurin Artem, drdoomenator@gmail.com, for digimonworld.ru";
                    break;
            }

            about.Show();
        }


        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
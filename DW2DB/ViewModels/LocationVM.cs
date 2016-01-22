using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DB;
using DW2DB.Annotations;

namespace DW2DB.ViewModels
{
    public class LocationVM : INotifyPropertyChanged
    {
        public Location Source { get; set; }

        public DomainVM DomainVM { get; set; }

        public LocationVM(Location source)
        {

            Source = source;
            if(source.Domain!=null)
                DomainVM = new DomainVM(Source.Domain);
        }


        public string Name
        {
            get { return DomainVM!=null?DomainVM.Name + " " + String.Join(",", Source.Floors):
                    App.Language.Name == "ru-RU"?Source.DescriptionRus:Source.DescriptionEng; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class DomainVM : INotifyPropertyChanged
    {
        public Domain Source { get; set; }

        public DomainVM(Domain source)
        {
            Source = source;
            UpdateFields();

        }

        private void UpdateFields()
        {
            switch (App.Language.Name)
            {
                case "ru-RU":
                    Name = Source.NameRus;
                    break;
                default:
                    Name = Source.NameEng;
                    break;
            }
            OnPropertyChanged(nameof(Name));
        }

        public string Name { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
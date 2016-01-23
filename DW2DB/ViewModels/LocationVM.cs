using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataBase;
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
}
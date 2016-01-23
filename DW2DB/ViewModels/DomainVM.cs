using System.ComponentModel;
using DataBase;
using DW2DB.Annotations;

namespace DW2DB.ViewModels
{
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
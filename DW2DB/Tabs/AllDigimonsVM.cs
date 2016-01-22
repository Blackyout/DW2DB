using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DW2DB.Annotations;
using DW2DB.ViewModels;

namespace DW2DB
{
    public class AllDigimonsVM : INotifyPropertyChanged
    {
        public DigimonVM SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value; 
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        private ObservableCollection<DigimonVM> _allDigimons;
        private string _nameFilter;

        private DigimonVM _selectedItem;

        public AllDigimonsVM()
        {
            AllDigimons = new ObservableCollection<DigimonVM>(DB.DB.Digimons.Select(x => new DigimonVM(x)));
        }


        public ObservableCollection<DigimonVM> AllDigimons
        {
            get { return _allDigimons; }
            set
            {
                _allDigimons = value;
                OnPropertyChanged(nameof(AllDigimons));
            }
        }

        public ObservableCollection<DigimonVM> FilteredDigimons
        {
            get { return new ObservableCollection<DigimonVM>(
                AllDigimons.Where(x => string.IsNullOrWhiteSpace(NameFilter) || x.Name.Contains(NameFilter))); }
        }

        public string NameFilter
        {
            get { return _nameFilter; }
            set
            {
                _nameFilter = value;
                OnPropertyChanged(nameof(NameFilter));
                OnPropertyChanged(nameof(FilteredDigimons));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

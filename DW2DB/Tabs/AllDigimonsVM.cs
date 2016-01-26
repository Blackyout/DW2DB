using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBase;
using DW2DB.Annotations;
using DW2DB.ViewModels;

namespace DW2DB
{
    public class AllDigimonsVM : INotifyPropertyChanged
    {
        public ICommand NavigateToCmd { get; set; }

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
            NavigateToCmd = new DelegateCommand<DigimonVM>(DoNavigateTo);

            AllDigimons = new ObservableCollection<DigimonVM>();
        }

        public void Load()
        {
            AllDigimons = new ObservableCollection<DigimonVM>(DBLoader.AllDigimons);
        }

        private void DoNavigateTo(DigimonVM obj)
        {
            NameFilter = string.Empty;
            SelectedItem = obj;
        }

        public ObservableCollection<DigimonVM> AllDigimons
        {
            get { return _allDigimons; }
            set
            {
                _allDigimons = value;
                OnPropertyChanged(nameof(AllDigimons));
                OnPropertyChanged(nameof(FilteredDigimons));
            }
        }

        public ObservableCollection<DigimonVM> FilteredDigimons
        {
            get { return new ObservableCollection<DigimonVM>(
                AllDigimons.Where(x => string.IsNullOrWhiteSpace(NameFilter) 
                || x.Source.NameEng.ToLower().Contains(NameFilter.ToLower())
                || x.Source.NameRus.ToLower().Contains(NameFilter.ToLower()))
                ); }
        }

        public string NameFilter
        {
            get { return _nameFilter; }
            set
            {
                _nameFilter = value;
                SelectedItem = null;
                OnPropertyChanged(nameof(NameFilter));
                OnPropertyChanged(nameof(FilteredDigimons));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

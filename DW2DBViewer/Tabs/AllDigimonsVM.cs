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
using DW2DBViewer.ViewModels;

namespace DW2DBViewer
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
        private decimal _percent;
        private bool _dataLoaded;

        public AllDigimonsVM()
        {
            DBLoader.PercentDigimonChanged += PercentChanged;
            DBLoader.DigimonLoadCompleted += LoadCompleted;
            NavigateToCmd = new DelegateCommand<DigimonVM>(DoNavigateTo);

            AllDigimons = new ObservableCollection<DigimonVM>();
        }

        private void LoadCompleted(List<DigimonVM> digimonVms)
        {
            AllDigimons = new ObservableCollection<DigimonVM>(digimonVms);
            DataLoaded = true;
        }

        public bool DataLoaded
        {
            get { return _dataLoaded; }
            set
            {
                _dataLoaded = value;
                OnPropertyChanged(nameof(DataLoaded));
            }
        }


        public decimal Percent
        {
            get { return _percent; }
            set
            {
                _percent = value;
                OnPropertyChanged(nameof(Percent));
            }
        }

        private void PercentChanged(decimal percent)
        {
            Percent = percent;
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

        protected virtual void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

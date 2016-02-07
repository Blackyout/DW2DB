using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using DW2DBViewer.ViewModels;

namespace DW2DBViewer
{
    public class AllDigimonsVM : INotifyPropertyChanged
    {
        private ObservableCollection<DigimonVM> _allDigimons;
        private bool _dataLoaded;
        private bool _isSelected;
        private string _nameFilter;
        private decimal _percent;

        private DigimonVM _selectedItem;

        public AllDigimonsVM()
        {
            DBLoader.PercentDigimonChanged += PercentChanged;
            DBLoader.DigimonLoadCompleted += LoadCompleted;
            NavigateToCmd = new DelegateCommand<DigimonVM>(DoNavigateTo);

            AllDigimons = new ObservableCollection<DigimonVM>();
        }

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


        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
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
            get
            {
                return new ObservableCollection<DigimonVM>(
                    AllDigimons.Where(x => string.IsNullOrWhiteSpace(NameFilter)
                                           || x.Source.NameEng.ToLower().Contains(NameFilter.ToLower())
                                           || x.Source.NameRus.ToLower().Contains(NameFilter.ToLower()))
                    );
            }
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


        private void LoadCompleted(List<DigimonVM> digimonVms)
        {
            AllDigimons = new ObservableCollection<DigimonVM>(digimonVms);
            DataLoaded = true;
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

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void DigimonClicked(DigimonVM obj)
        {
            SelectedItem = obj;
            IsSelected = true;
        }
    }
}
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
                OnPropertyChanged(nameof(LocationStr));
            }
        }

        private ObservableCollection<DigimonVM> _allDigimons;
        private string _nameFilter;

        private DigimonVM _selectedItem;

        public AllDigimonsVM()
        {
            NavigateToCmd = new DelegateCommand<DigimonVM>(DoNavigateTo);


            AllDigimons = new ObservableCollection<DigimonVM>(DataBase.DB.Digimons.Select(x => new DigimonVM(x)));
            foreach (var allDigimon in AllDigimons)
            {
                //Ищем все скилы и проставляем
                allDigimon.Skills = new ObservableCollection<SkillVM>(DataBase.DB.Skills.Where(x => x.DigimonId == allDigimon.Source.NameEng).Select(x=>new SkillVM(x)));
                //Ищем все локации и проставляем
                allDigimon.Locations = new ObservableCollection<LocationVM>(DataBase.DB.Locations.Where(x => x.DigimonId == allDigimon.Source.NameEng).Select(x=>new LocationVM(x)));
                //Ищем дигимонов из которых превращается конкретно этот
                allDigimon.DigivolveFrom = new ObservableCollection<DigivolveDigimonVM>(
                    DataBase.DB.Digivolves.Where(x => x.DigimonToId == allDigimon.Source.NameEng)
                        .Select(x => new DigivolveDigimonVM(AllDigimons.FirstOrDefault(y => y.Source.NameEng == x.DigimonFromId),x.DP)));
                //Ищем дигимонов в которых превращается конкретно этот
                allDigimon.DigivolveTo = new ObservableCollection<DigivolveDigimonVM>(
                    DataBase.DB.Digivolves.Where(x => x.DigimonFromId == allDigimon.Source.NameEng)
                        .Select(x => new DigivolveDigimonVM(AllDigimons.FirstOrDefault(y => y.Source.NameEng == x.DigimonToId),x.DP)));

            }
        }

        private void DoNavigateTo(DigimonVM obj)
        {
            NameFilter = string.Empty;
            SelectedItem = obj;
        }

        public string LocationStr
        {
            get
            {
                if(SelectedItem == null) return String.Empty;
                return String.Join(";",SelectedItem.Locations.Select(x => x.Name));
            }
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

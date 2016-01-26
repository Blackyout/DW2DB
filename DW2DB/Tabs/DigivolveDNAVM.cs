using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBase;
using DW2DB.Annotations;
using DW2DB.ViewModels;

namespace DW2DB.Tabs
{
    public class DigivolveDNAVM : INotifyPropertyChanged
    {
        public List<int> Levels(Rank rank)
        {
            int min = 0;
            switch (rank)
            {
                case Rank.Champion:
                    min = 11;
                    break;
                case Rank.Ultimate:
                    min = 21;
                    break;
                case Rank.Mega:
                    min = 31;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rank), rank, null);
            }

            var result = new List<int>();
            for (int i = min; i < 100; i++)
            {
                result.Add(i);
            }
            return result;
        }


        private ObservableCollection<DigimonVM> _digimons;
        private DigimonVM _parent1;
        private DigimonVM _parent2;
        private DigimonVM _result;
        private ObservableCollection<DigimonVM> _allDigimons;
        private DigivolveDNAOptionVM _selectedOption;
        private int _parent1Level;
        private int _parent2Level;
        private List<int> _parent1Levels;
        private List<int> _parent2Levels;


        public ICommand ClearParent1CMD { get; set; }
        public ICommand ClearParent2CMD { get; set; }
        public ICommand ClearResultCMD { get; set; }

        public ICommand LoadCmd { get; set; }

        public DigivolveDNAVM()
        {
            DBLoader.PercentDNAChanged += PercentChanged;
            ClearParent1CMD = new DelegateCommand(ClearParent1);
            ClearParent2CMD = new DelegateCommand(ClearParent2);
            ClearResultCMD = new DelegateCommand(ClearResult);
            // LoadCmd = new DelegateCommand(DoLoad);
            AllDigimons = new ObservableCollection<DigimonVM>();
            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>();
            //DoLoad();
        }
        private decimal _percent;
        public decimal Percent
        {
            get { return _percent; }
            set
            {
                _percent = value;
                OnPropertyChanged(nameof(Percent));
            }
        }

        private void PercentChanged()
        {
            Percent = DBLoader.PercentLoadDNA;
        }

        public void Load()
        {
            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>(DBLoader.AllOptions);

            AllDigimons = new ObservableCollection<DigimonVM>(DBLoader.AllDigimons);

            //отсеиваем новичков
            Digimons = new ObservableCollection<DigimonVM>(DBLoader.NoRookie);
        }

        private void ClearResult()
        {
            Result = null;
        }

        private void ClearParent2()
        {
            Parent2 = null;
        }

        private void ClearParent1()
        {
            Parent1 = null;
        }

        public DigivolveDNAOptionVM SelectedOption
        {
            get { return _selectedOption; }
            set
            {
                _selectedOption = value;

                if (value != null)
                {
                    _parent1 = SelectedOption.Parents[0];
                    _parent2 = SelectedOption.Parents[1];
                    _result = SelectedOption.Result;
                }

                OnPropertyChanged(nameof(SelectedOption));
                OnPropertyChanged(nameof(Parent1));
                OnPropertyChanged(nameof(Parent2));
                OnPropertyChanged(nameof(Result));
            }
        }


        public List<int> Parent1Levels
        {
            get { return _parent1Levels; }
            set
            {
                _parent1Levels = value;
                OnPropertyChanged(nameof(Parent1Levels));
            }
        }

        public int Parent1Level
        {
            get { return _parent1Level; }
            set
            {
                _parent1Level = value;
                OnPropertyChanged(nameof(Parent1Level));
                OnPropertyChanged(nameof(MaxLevel));
            }
        }

        public int MaxLevel
        {
            get { return Parent1Level + Parent2Level/5; }
        }


        public DigimonVM Parent1
        {
            get { return _parent1; }
            set
            {
                _parent1 = value;
                SelectedOption = null;
                SetResult();

                if (Parent1 != null)
                {
                    Parent1Levels = Levels(Parent1.Source.Rank);
                    Parent1Level = Parent1Levels.FirstOrDefault();
                }
                else
                {
                    Parent1Levels = null;
                }


                OnPropertyChanged(nameof(Parent1));
                OnPropertyChanged(nameof(Result));
                OnPropertyChanged(nameof(FilteredOptions));
                OnPropertyChanged(nameof(Parent1Levels));
            }
        }

        private void SetResult()
        {
            if (Parent1 != null && Parent2 != null && AllOptions.Any())
            {
                var temp = AllOptions.FirstOrDefault(x => (Parent1 != Parent2 && x.Parents.Contains(Parent1) && x.Parents.Contains(Parent2))
                || (Parent1 == Parent2 &&  x.Parents.All(y => y == Parent1)));
                if (temp != null)
                    _result = temp.Result;
                else
                    _result = null;
            }
            else
            {
                _result = null;
            }
        }



        public List<int> Parent2Levels
        {
            get { return _parent2Levels; }
            set
            {
                _parent2Levels = value;
                OnPropertyChanged(nameof(Parent2Levels));
            }
        }

        public int Parent2Level
        {
            get { return _parent2Level; }
            set
            {
                _parent2Level = value;
                OnPropertyChanged(nameof(Parent2Level));
                OnPropertyChanged(nameof(MaxLevel));
            }
        }



        public DigimonVM Parent2
        {
            get { return _parent2; }
            set
            {
                _parent2 = value;
                SelectedOption = null;
                SetResult();


                if (Parent2 != null)
                {
                    Parent2Levels = Levels(Parent2.Source.Rank);
                    Parent2Level = Parent2Levels.FirstOrDefault();
                }
                else
                {
                    Parent2Levels = null;
                }


                OnPropertyChanged(nameof(Parent2));
                OnPropertyChanged(nameof(Result));
                OnPropertyChanged(nameof(FilteredOptions));
            }
        }

        public DigimonVM Result
        {
            get { return _result; }
            set
            {
                _result = value;
                if (_result == null)
                {
                    _parent1 = null;
                    _parent2 = null;
                }

                SelectedOption = null;
                OnPropertyChanged(nameof(Result));
                OnPropertyChanged(nameof(Parent1));
                OnPropertyChanged(nameof(Parent2));
                OnPropertyChanged(nameof(FilteredOptions));
            }
        }

        public ObservableCollection<DigimonVM> Digimons
        {
            get { return _digimons; }
            set
            {
                _digimons = value;
                OnPropertyChanged(nameof(Digimons));
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

        public ObservableCollection<DigivolveDNAOptionVM> AllOptions { get; set; }

        public ObservableCollection<DigivolveDNAOptionVM> FilteredOptions
        {
            get { return new ObservableCollection<DigivolveDNAOptionVM>(AllOptions.Where(x => (Parent1 == null && Parent2 == null && Result == null) || (Parent1 != Parent2 && (Parent1 == null || x.Parents.Contains(Parent1)) && (Parent2 == null || x.Parents.Contains(Parent2)) && (Result == null || x.Result == Result)) || (Parent1 == Parent2 && x.Parents.All(y => y == Parent1)))); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

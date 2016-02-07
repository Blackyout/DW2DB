using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using DataBase;
using DW2DBViewer.ViewModels;

namespace DW2DBViewer.Tabs
{
    public class DigivolveDNAVM : INotifyPropertyChanged
    {
        private ObservableCollection<DigimonVM> _allDigimons;

        private bool _dataLoaded;


        private ObservableCollection<DigimonVM> _digimons;
        private DigimonVM _parent1;
        private int _parent1Level;
        private List<int> _parent1Levels;
        private DigimonVM _parent2;
        private int _parent2Level;
        private List<int> _parent2Levels;

        private decimal _percent;
        private DigimonVM _result;
        private DigivolveDNAOptionVM _selectedOption;

        public Action<DigimonVM> DigimonClicked;

        public DigivolveDNAVM()
        {
            DBLoader.PercentDNAChanged += PercentChanged;
            DBLoader.DNALoadCompleted += LoadCompleted;
            ClearParent1CMD = new DelegateCommand(ClearParent1);
            ClearParent2CMD = new DelegateCommand(ClearParent2);
            ClearResultCMD = new DelegateCommand(ClearResult);
            DigimonDetailsCmd = new DelegateCommand<DigimonVM>(DoDigimonDetails, x => x != null);
            // LoadCmd = new DelegateCommand(DoLoad);
            AllDigimons = new ObservableCollection<DigimonVM>();
            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>();
            //DoLoad();
        }


        public ICommand ClearParent1CMD { get; set; }
        public ICommand ClearParent2CMD { get; set; }
        public ICommand ClearResultCMD { get; set; }
        public ICommand DigimonDetailsCmd { get; set; }
        public ICommand LoadCmd { get; set; }

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
            get
            {
                return
                    new ObservableCollection<DigivolveDNAOptionVM>(
                        AllOptions.Where(
                            x =>
                                (Parent1 == null && Parent2 == null && Result == null) ||
                                (Parent1 != Parent2 && (Parent1 == null || x.Parents.Contains(Parent1)) &&
                                 (Parent2 == null || x.Parents.Contains(Parent2)) &&
                                 (Result == null || x.Result == Result)) ||
                                (Parent1 == Parent2 && x.Parents.All(y => y == Parent1))));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public List<int> Levels(Rank rank)
        {
            var min = 0;
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
            for (var i = min; i < 100; i++)
            {
                result.Add(i);
            }
            return result;
        }

        private void DoDigimonDetails(DigimonVM obj)
        {
            DigimonClicked?.Invoke(obj);
        }

        private void LoadCompleted(List<DigimonVM> digimons, List<DigivolveDNAOptionVM> dnas)
        {
            //AllOptions = new ObservableCollection<DigivolveDNAOptionVM>(dnas);
            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>();

            AllDigimons = new ObservableCollection<DigimonVM>(digimons);

            //отсеиваем новичков
            Digimons = new ObservableCollection<DigimonVM>(digimons.Where(x => x.Source.Rank != Rank.Rookie));
            DataLoaded = true;
        }

        private void PercentChanged(decimal percent)
        {
            Percent = percent;
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

        private void SetResult()
        {
            if (Parent1 != null && Parent2 != null)
            {
                var dna = DNATables.GetChild(Parent1.Source.NameEng, Parent2.Source.NameEng);
                if (dna != null)
                {
                    _result = AllDigimons.FirstOrDefault(x => x.Source.NameEng == dna.DigimonChildId);
                }
            }


            //            if (Parent1 != null && Parent2 != null && AllOptions.Any())
            //            {
            //                var temp = AllOptions.FirstOrDefault(x => (Parent1 != Parent2 && x.Parents.Contains(Parent1) && x.Parents.Contains(Parent2))
            //                || (Parent1 == Parent2 &&  x.Parents.All(y => y == Parent1)));
            //                if (temp != null)
            //                    _result = temp.Result;
            //                else
            //                    _result = null;
            //            }
            //            else
            //            {
            //                _result = null;
            //            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
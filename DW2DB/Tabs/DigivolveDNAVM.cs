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
        private ObservableCollection<DigimonVM> _digimons;
        private DigimonVM _parent1;
        private DigimonVM _parent2;
        private DigimonVM _result;
        private ObservableCollection<DigimonVM> _allDigimons;
        private DigivolveDNAOptionVM _selectedOption;



        public ICommand ClearParent1CMD { get; set; }
        public ICommand ClearParent2CMD { get; set; }
        public ICommand ClearResultCMD { get; set; }

        public ICommand LoadCmd { get; set; }

        public DigivolveDNAVM()
        {

            ClearParent1CMD = new DelegateCommand(ClearParent1);
            ClearParent2CMD = new DelegateCommand(ClearParent2);
            ClearResultCMD = new DelegateCommand(ClearResult);
            LoadCmd = new DelegateCommand(DoLoad);

            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>();
            AllDigimons = new ObservableCollection<DigimonVM>();
            Digimons = new ObservableCollection<DigimonVM>();


            //DB.Fill();

           


        }

        private void DoLoad()
        {
            DB.Fill();
            AllOptions = new ObservableCollection<DigivolveDNAOptionVM>(
               DB.DigivolvesDNA.Select(x => new DigivolveDNAOptionVM(x))
               );

            AllDigimons = new ObservableCollection<DigimonVM>(
                DataBase.DB.Digimons.
                Select(x => new DigimonVM(x)));

            //отсеиваем новичков
            Digimons = new ObservableCollection<DigimonVM>(
                DataBase.DB.Digimons.Where(x => x.Rank != Rank.Rookie).
                Select(x => new DigimonVM(x)));
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

                    _parent1 = Digimons.FirstOrDefault(x => x.Source.Id == value.Parent1.Source.Id);
                    _parent2 = Digimons.FirstOrDefault(x => x.Source.Id == value.Parent2.Source.Id);
                    _result = AllDigimons.FirstOrDefault(x => x.Source.Id == value.Result.Source.Id);
                }

                OnPropertyChanged(nameof(SelectedOption));
                OnPropertyChanged(nameof(Parent1));
                OnPropertyChanged(nameof(Parent2));
                OnPropertyChanged(nameof(Result));
            }
        }


        public DigimonVM Parent1
        {
            get { return _parent1; }
            set
            {
                _parent1 = value;
                SelectedOption = null;
                SetResult();
                OnPropertyChanged(nameof(Parent1));
                OnPropertyChanged(nameof(Result));
                OnPropertyChanged(nameof(FilteredOptions));
            }
        }

        private void SetResult()
        {
            if (Parent1 != null && Parent2 != null && AllOptions.Any())
            {
                _result = AllDigimons.FirstOrDefault(y => y.Source.Id ==
                AllOptions.FirstOrDefault(
                    x =>
                    (x.Parent1.Source.Id == Parent1.Source.Id &&
                    x.Parent2.Source.Id == Parent2.Source.Id)
                    ||
                     (x.Parent2.Source.Id == Parent1.Source.Id &&
                    x.Parent1.Source.Id == Parent2.Source.Id)
                    ).Result.Source.Id);
                
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
                SelectedOption = null;
                OnPropertyChanged(nameof(Result));
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
                return new ObservableCollection<DigivolveDNAOptionVM>();
//                    AllOptions.Where(
//                    x=>(Parent1==null && Parent2 == null && Result == null)
//                    || (
//                    
//                        (Parent1 == null || x.Source.DigimonParent1Id == Parent1.Source.Id)
//                    && (Parent2 == null || x.Source.DigimonParent2Id == Parent2.Source.Id)
//                    && (Result == null || x.Source.DigimonChildId == Result.Source.Id)
//                            )
//                            ||
//                            (
//
//                        (Parent1 == null || x.Source.DigimonParent2Id == Parent1.Source.Id)
//                    && (Parent2 == null || x.Source.DigimonParent1Id == Parent2.Source.Id)
//                    && (Result == null || x.Source.DigimonChildId == Result.Source.Id)
//                            )
//
//                            ));
            }
        }






        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

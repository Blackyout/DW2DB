using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using DW2DB.Annotations;

namespace DW2DB.ViewModels
{
    public class DigimonVM : INotifyPropertyChanged
    {
        private ObservableCollection<SkillVM> _skills;
        private ObservableCollection<LocationVM> _locations;
        private ObservableCollection<DigivolveDigimonVM> _digivolveFrom;
        private ObservableCollection<DigivolveDigimonVM> _digivolveTo;
        public Digimon Source { get; set; }

        public DigimonVM(Digimon source)
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
                    Rank = ClassHelper.RankRus[Source.Rank];
                    Type = ClassHelper.TypeRus[Source.Type];
                    Speciality = ClassHelper.SpecialityRus[Source.Specialty];
                    break;
                default:
                    Name = Source.NameEng;
                    Rank = ClassHelper.RankEng[Source.Rank];
                    Type = ClassHelper.TypeEng[Source.Type];
                    Speciality = ClassHelper.SpecialityEng[Source.Specialty];
                    break;
            }
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Rank));
            OnPropertyChanged(nameof(Type));
            OnPropertyChanged(nameof(Speciality));

        }

        public string Name { get; set; }

        public string Rank { get; set; }

        public string Type { get; set; }

        public string Speciality { get; set; }

        public ObservableCollection<SkillVM> Skills
        {
            get { return _skills; }
            set
            {
                _skills = value;
                OnPropertyChanged(nameof(Skills));
            }
        }

        public ObservableCollection<LocationVM> Locations
        {
            get { return _locations; }
            set
            {
                _locations = value;
                OnPropertyChanged(nameof(Locations));
            }
        }

        public ObservableCollection<DigivolveDigimonVM> DigivolveFrom
        {
            get { return _digivolveFrom; }
            set
            {
                _digivolveFrom = value;
                OnPropertyChanged(nameof(DigivolveFrom));
            }
        }

        public ObservableCollection<DigivolveDigimonVM> DigivolveTo
        {
            get { return _digivolveTo; }
            set
            {
                _digivolveTo = value;
                OnPropertyChanged(nameof(DigivolveTo));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DigivolveDigimonVM
    {
        public DigivolveDigimonVM(DigimonVM digimon, int dp)
        {
            Digimon = digimon;
            DP = dp;
        }

        public DigimonVM Digimon { get; set; }

        public int DP { get; set; }
    }


}

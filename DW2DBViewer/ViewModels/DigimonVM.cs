using System.Collections.ObjectModel;
using DataBase;

namespace DW2DBViewer.ViewModels
{
    public class DigimonVM
    {
        public Digimon Source { get; set; }

        public string Name { get; set; }

        public string Rank { get; set; }

        public string Type { get; set; }

        public string Speciality { get; set; }

        public string LocationStr { get; set; }

        public ObservableCollection<SkillVM> Skills { get; set; }

        public ObservableCollection<DigivolveDigimonVM> DigivolveFrom { get; set; }

        public ObservableCollection<DigivolveDigimonVM> DigivolveTo { get; set; }

        public string NameFull
        {
            get { return $"{Name}({Rank})"; }
        }
    }

    public class DigivolveDigimonVM
    {
        public DigimonVM Digimon { get; set; }

        public int DP { get; set; }
    }
}
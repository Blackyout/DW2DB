using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

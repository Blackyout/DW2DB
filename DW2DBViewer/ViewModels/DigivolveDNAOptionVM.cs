using System.Collections.Generic;
using DataBase;

namespace DW2DBViewer.ViewModels
{
    public class DigivolveDNAOptionVM
    {
        public DigivolveDNA Source { get; set; }

        public List<DigimonVM> Parents { get; set; }

        public DigimonVM Result { get; set; }

        public string Mutation { get; set; }
    }
}
using System.Linq;
using DataBase;

namespace DW2DB.ViewModels
{
    public class DigivolveDNAOptionVM
    {

        public DigivolveDNA Source { get; set; }

        public DigivolveDNAOptionVM(DigivolveDNA source)
        {
            Source = source;
//            Parent1 = new DigimonVM(DB.Digimons.FirstOrDefault(x => x.Id == source.DigimonParent1Id));
//            Parent2 = new DigimonVM(DB.Digimons.FirstOrDefault(x => x.Id == source.DigimonParent2Id));
//            Result = new DigimonVM(DB.Digimons.FirstOrDefault(x => x.Id == source.DigimonChildId));
        }


        public DigimonVM Parent1 { get; set; }
        public DigimonVM Parent2 { get; set; }
        public DigimonVM Result { get; set; }
    }
}
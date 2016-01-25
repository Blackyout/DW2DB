using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class DigivolveDNA
    {
        public DigivolveDNA()
        {
            Id = Guid.NewGuid();
        }

        public DigivolveDNA(string digimonParent1Id, string digimonParent2Id, string digimonChildId)
        {
            Id = Guid.NewGuid();
            DigimonParent1Id = digimonParent1Id;
            DigimonParent2Id = digimonParent2Id;
            DigimonChildId = digimonChildId;
        }

        public Guid Id { get; set; }

        [NotMapped]
        public string DigimonParent1Id { get; set; }
        [NotMapped]
        public string DigimonParent2Id { get; set; }
        [NotMapped]
        public string DigimonChildId { get; set; }

        public virtual Digimon Result { get; set; }

        public virtual List<DigivolveDNAParent> Parents { get; set; } 
    }

    public class DigivolveDNAParent
    {
        public DigivolveDNAParent()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
           
        public virtual Digimon Parent { get; set; }

        public virtual DigivolveDNA DigivolveDna { get; set; } 
    }



}
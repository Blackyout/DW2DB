using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Digivolve
    {
        public Digivolve()
        {
            Id = Guid.NewGuid();
        }

        public Digivolve(string digimonFromId, string digimonToId, int dp)
        {
            Id = Guid.NewGuid();
            DigimonFromId = digimonFromId;
            DigimonToId = digimonToId;
            DP = dp;
        }

        public Guid Id { get; set; } 

        public virtual Digimon DigimonFrom { get; set; }

        public virtual Digimon DigimonTo { get; set; }

        [NotMapped]
        public string DigimonFromId { get; set; }

//        public virtual Digimon DigimonTo{ get; set; }

        [NotMapped]
        public string DigimonToId { get; set; }

        public int DP { get; set; }

    }
}
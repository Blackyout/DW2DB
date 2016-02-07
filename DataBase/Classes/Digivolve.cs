using System;

namespace DataBase
{
    public class Digivolve
    {
        public Digivolve(string digimonFromId, string digimonToId, int dp)
        {
            DigimonFromId = digimonFromId;
            DigimonToId = digimonToId;
            DP = dp;
        }

        public string DigimonFromId { get; set; }

        public string DigimonToId { get; set; }

        public int DP { get; set; }

    }
}
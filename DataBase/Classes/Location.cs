using System.Collections.Generic;

namespace DataBase
{
    public class Location
    {
        public Location(string digimonId, Domain domain, List<int> floors)
        {
            DigimonId = digimonId;
            Domain = domain;
            Floors = floors;
        }

        public Location(string digimonId, string descriptionEng, string descriptionRus)
        {
            Floors = new List<int>();
            DigimonId = digimonId;
            DescriptionEng = descriptionEng;
            DescriptionRus = descriptionRus;
        }
        public string DigimonId { get; set; }

        public Domain Domain { get; set; }

        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionEng { get; set; }
        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionRus { get; set; }

        public List<int> Floors { get; set; } 
    }
}
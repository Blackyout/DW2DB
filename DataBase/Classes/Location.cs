using System;
using System.Collections.Generic;
using System.Linq;

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

        public virtual Domain Domain { get; set; }

        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionEng { get; set; }
        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionRus { get; set; }

        public List<int> Floors
        {
            get { return FloorsClasses.Select(x => x.Num).ToList(); }
            set { FloorsClasses = value.Select(x => new Floor {Num = x}).ToList(); }
        }  

        public virtual IList<Floor> FloorsClasses { get; set; } 
    }

    public class Floor
    {
        public int Num { get; set; }
    }



}
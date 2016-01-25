using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DataBase
{
    public class Location
    {
        public Location()
        {
            Id = Guid.NewGuid();
        }

        public Location(string digimonId, Domain domain, List<int> floors)
        {
            Id = Guid.NewGuid();
            DigimonId = digimonId;
            Domain = domain;
            Floors = floors;
        }

        public Location(string digimonId, string descriptionEng, string descriptionRus)
        {
            Id = Guid.NewGuid();
            Floors = new List<int>();
            DigimonId = digimonId;
            DescriptionEng = descriptionEng;
            DescriptionRus = descriptionRus;
        }

        [NotMapped]
        public string DigimonId { get; set; }


        public Guid Id { get; set; }

        public virtual Domain Domain { get; set; }

        public virtual Digimon Digimon { get; set; }

        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionEng { get; set; }
        /// <summary>
        /// На случай если нет домена
        /// </summary>
        public string DescriptionRus { get; set; }

        [NotMapped]
        public List<int> Floors
        {
            get { return FloorsClasses.Select(x => x.Num).ToList(); }
            set { FloorsClasses = value.Select(x => new Floor {Num = x}).ToList(); }
        }  

        public virtual IList<Floor> FloorsClasses { get; set; } 
    }

    public class Floor
    {
        public Floor()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


        public int Num { get; set; }
    }



}
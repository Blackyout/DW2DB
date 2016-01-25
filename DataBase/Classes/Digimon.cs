using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    /// <summary>
    /// Класс дигимона
    /// </summary>
    public class Digimon
    {
        public Digimon()
        {
            Id = Guid.NewGuid(); 
        }


        public Digimon(string nameRus, string nameEng, Rank rank)
        {
            Id = Guid.NewGuid();
            NameEng = nameEng;
            NameRus = nameRus;
            Rank = rank;
        }

        public Digimon(string nameRus, string nameEng, Rank rank, Type type, Speciality speciality)
        {
            Id = Guid.NewGuid();
            NameEng = nameEng;
            NameRus = nameRus;
            Rank = rank;
            Type = type;
            Speciality = speciality;
        }

        public Guid Id { get; set; }


//        [NotMapped

//        /// <summary>
//        /// Id будет наименование на английском
//        /// </summary>
//        public string Id => NameEng;

        /// <summary>
        /// Наименование на английском
        /// </summary>
        public string NameEng { get; set; }

        /// <summary>
        /// Наименование на русском
        /// </summary>
        public string NameRus { get; set; }

        /// <summary>
        /// Ранк дигимона
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// Тип дигимона
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Специальность
        /// </summary>
        public Speciality Speciality { get; set; }

        public virtual List<Skill> Skills { get; set; } 

        public virtual List<Location> Locations { get; set; }
//
        public virtual List<Digivolve> DigivolesFrom { get; set; }
        public virtual List<Digivolve> DigivolesTo { get; set; }
        //public virtual List<Digivolve> Digivoles { get; set; }
         
        
         

    }

    /// <summary>
    /// Все формы дигимонов
    /// </summary>
    public enum Rank
    {
        /// <summary>
        /// Новичок
        /// </summary>
        Rookie = 0,

        /// <summary>
        /// Чемпион
        /// </summary>
        Champion = 1,

        /// <summary>
        /// Высший
        /// </summary>
        Ultimate = 2,

        /// <summary>
        /// Мега
        /// </summary>
        Mega = 3
    }


    /// <summary>
    /// Тип дигимона
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Вирус
        /// </summary>
        Virus,

        /// <summary>
        /// Дата
        /// </summary>
        Data,

        /// <summary>
        /// Вакцина
        /// </summary>
        Vaccine
    }


    public enum Speciality
    {
        None,
        Nature,
        Fire,
        Water,
        Darkness,
        Machine
    }
}
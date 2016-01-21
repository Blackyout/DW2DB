using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DB
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

    /// <summary>
    /// Класс дигимона
    /// </summary>
    public class Digimon
    {
        public Digimon(string nameRus, string nameEng, Rank rank)
        {
            NameEng = nameEng;
            NameRus = nameRus;
            Rank = rank;
        }

        public Digimon(string nameRus, string nameEng, Rank rank, Type type, Speciality speciality)
        {
            NameEng = nameEng;
            NameRus = nameRus;
            Rank = rank;
            Type = type;
            Specialty = speciality;
        }
        /// <summary>
        /// Id будет наименование на английском
        /// </summary>
        public string Id => NameEng;
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
        public Speciality Specialty { get; set; }

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

    public static class ClassHelper
    {
        public static Dictionary<Rank, string> RankEng = new Dictionary<Rank, string>()
        {
            {Rank.Rookie,"Rookie"},
            {Rank.Champion,"Champion"},
            {Rank.Ultimate,"Ultimate"},
            {Rank.Mega,"Mega"},
        };
        public static Dictionary<Rank, string> RankRus = new Dictionary<Rank, string>()
        {
            {Rank.Rookie,"Новичок"},
            {Rank.Champion,"Чемпион"},
            {Rank.Ultimate,"Высший"},
            {Rank.Mega,"Мега"},
        };


        public static Dictionary<Type, string> TypeEng = new Dictionary<Type, string>()
        {
            {Type.Virus,"Virus"},
            {Type.Data,"Data"},
            {Type.Vaccine,"Vaccine"},
        };

        public static Dictionary<Type, string> TypeRus = new Dictionary<Type, string>()
        {
            {Type.Virus,"Вирус"},
            {Type.Data,"Данные"},
            {Type.Vaccine,"Вакцина"},
        };

        public static Dictionary<Speciality, string> SpecialityEng = new Dictionary<Speciality, string>()
        {
            {Speciality.None,"None"},
            {Speciality.Nature,"Nature"},
            {Speciality.Fire,"Fire"},
            {Speciality.Water,"Water"},
            {Speciality.Darkness,"Darkness"},
            {Speciality.Machine,"Machine"},
        };

        public static Dictionary<Speciality, string> SpecialityRus = new Dictionary<Speciality, string>()
        {
            {Speciality.None,"Нет"},
            {Speciality.Nature,"Природа"},
            {Speciality.Fire,"Огонь"},
            {Speciality.Water,"Вода"},
            {Speciality.Darkness,"Тьма"},
            {Speciality.Machine,"Машина"},
        };
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
   
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

        public static Dictionary<SkillType, string> SkillTypeRus = new Dictionary<SkillType, string>()
        {
            {SkillType.Attack,"Аттака"},
            {SkillType.CounterAttack,"Контратака"},
            {SkillType.Interrupt,"Прерывание"},
            {SkillType.Assist,"Помощь"},
        };

        public static Dictionary<SkillType, string> SkillTypeEng = new Dictionary<SkillType, string>()
        {
            {SkillType.Attack,"Attack"},
            {SkillType.CounterAttack,"CounterAttack"},
            {SkillType.Interrupt,"Interrupt"},
            {SkillType.Assist,"Assist"},
        };
    }

}

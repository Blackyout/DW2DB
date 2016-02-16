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
            {SkillType.Attack,"Атака"},
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

        public static Dictionary<SkillSource,string> SkillSourceRus = new Dictionary<SkillSource, string>()
        {
            {SkillSource.Wild, "Эта атака встречается только у диких дигимонов." },
            {SkillSource.Wild1, "Эту атаку можно получить только взломав игру через Gameshark." },
            {SkillSource.Wild2, "Эта атака встречается только у босса в Патч-домене." },
            {SkillSource.Wild3, "Эта атака встречается только у босса в Мега-домене." },
            {SkillSource.Wild4, "Эта атака встречается только у босса в Дата-домене." },
            {SkillSource.Wild5, "Эта атака встречается только у дикого МеталГреймона в Биос-домене." },
        };


        public static Dictionary<SkillSource, string> SkillSourceEng = new Dictionary<SkillSource, string>()
        {
            {SkillSource.Wild,  "Only wild digimon have this move." },
            {SkillSource.Wild1, "You can unlock this move only using Gameshark." },
            {SkillSource.Wild2, "Only Patch Domain boss have this move." },
            {SkillSource.Wild3, "Only Mega Domain boss have this move." },
            {SkillSource.Wild4, "Only Data Domain boss have this move." },
            {SkillSource.Wild5, "Only wild MetalGreymon in a Patch Domain have this move." },
        };
    }

}

using System;

namespace DataBase
{
    public class Skill
    {   
        public Skill(string digimonId, SkillType type, string nameRus, string nameEng, string descriptionRus, 
            string descriptionEng, int mp,decimal ap, SkillSource skillSource = SkillSource.Native)
        {
            DigimonId = digimonId;
            Type = type;
            NameRus = nameRus;
            NameEng = nameEng;
            DescriptionRus = descriptionRus;
            DescriptionEng = descriptionEng;
            MP = mp;
            AP = ap;
            SkillSource = skillSource;
        }

        public SkillSource SkillSource { get; set; }
        
        public string DigimonId { get; set; }

        public virtual Digimon Digimon { get; set; }

        public SkillType Type { get; set; }

        public string NameRus { get; set; }

        public string NameEng { get; set; }

        public string DescriptionRus { get; set; }

        public string DescriptionEng { get; set; }

        public int MP { get; set; }

        public decimal AP { get; set; }

    }

    public enum SkillSource
    {
        Native = 0,
        Wild = 1,
        Wild1 = 2,
        Wild2 = 3,
        Wild3 = 4,
        Wild4 = 5,
        Wild5 = 6,
   
       
    }

    public enum SkillType
    {
        /// <summary>
        /// Атака
        /// </summary>
        Attack,
        /// <summary>
        /// Контраатака
        /// </summary>
        CounterAttack,
        /// <summary>
        /// Прерывание
        /// </summary>
        Interrupt,
        /// <summary>
        /// Помощь
        /// </summary>
        Assist
    }
}
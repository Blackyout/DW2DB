using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Skill
    {
        public Skill()
        {
            Id = Guid.NewGuid();
        }
        
        public Skill(string digimonId, SkillType type, string nameRus, string nameEng, string descriptionRus, 
            string descriptionEng, int mp,decimal ap, SkillSource skillSource = SkillSource.Native)
        {
            Id = Guid.NewGuid();
            DigimonId = digimonId;
            Type = type;
            NameRus = nameRus;
            NameEng = nameEng;
            DescriptionRus = descriptionRus;
            DescriptionEng = descriptionEng;
            MP = mp;
            AP = ap;
        }


        [NotMapped]
        public string DigimonId { get; set; }

        public Guid Id { get; set; }
        
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
//    Сноски:
//SkillSource.Wild Эта атака встречается только у диких дигимонов.
//SkillSource.Wild1 Эту атаку можно получить только взломав игру через Gameshark.
//SkillSource.Wild2 Эта атака встречается только у босса в Патч-домене.
//SkillSource.Wild3 Эта атака встречается только у босса в Мега-домене.
//SkillSource.Wild4 Эта атака встречается только у босса в Дата-домене.
//SkillSource.Wild5 Эта атака встречается только у дикого МеталГреймона в Биос-домене.



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
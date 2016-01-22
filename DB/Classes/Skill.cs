namespace DB
{
    public class Skill
    {
        public Skill(string digimonId, SkillType type, string nameRus, string nameEng, string descriptionRus, string descriptionEng, int mp)
        {
            DigimonId = digimonId;
            Type = type;
            NameRus = nameRus;
            NameEng = nameEng;
            DescriptionRus = descriptionRus;
            DescriptionEng = descriptionEng;
            MP = mp;
        }

        public string DigimonId { get; set; }

        public SkillType Type { get; set; }

        public string NameRus { get; set; }

        public string NameEng { get; set; }

        public string DescriptionRus { get; set; }

        public string DescriptionEng { get; set; }

        public int MP { get; set; }

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
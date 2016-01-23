namespace DataBase
{
    public class Skill
    {
        public Skill(string digimonId, SkillType type, string nameRus, string nameEng, string descriptionRus, string descriptionEng, int mp,decimal ap, SkillSource skillSource = SkillSource.Native)
        {
            DigimonId = digimonId;
            Type = type;
            NameRus = nameRus;
            NameEng = nameEng;
            DescriptionRus = descriptionRus;
            DescriptionEng = descriptionEng;
            MP = mp;
            AP = ap;
        }

        public string DigimonId { get; set; }

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
        Native,
        Wild
    }




    public enum SkillType
    {
        /// <summary>
        /// �����
        /// </summary>
        Attack,
        /// <summary>
        /// �����������
        /// </summary>
        CounterAttack,
        /// <summary>
        /// ����������
        /// </summary>
        Interrupt,
        /// <summary>
        /// ������
        /// </summary>
        Assist
    }
}
namespace DataBase
{
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
            Speciality = speciality;
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
        public Speciality Speciality { get; set; }

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
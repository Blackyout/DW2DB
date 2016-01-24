namespace DataBase
{
    /// <summary>
    /// ����� ��������
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
        /// Id ����� ������������ �� ����������
        /// </summary>
        public string Id => NameEng;

        /// <summary>
        /// ������������ �� ����������
        /// </summary>
        public string NameEng { get; set; }

        /// <summary>
        /// ������������ �� �������
        /// </summary>
        public string NameRus { get; set; }

        /// <summary>
        /// ���� ��������
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// ��� ��������
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// �������������
        /// </summary>
        public Speciality Speciality { get; set; }

    }

    /// <summary>
    /// ��� ����� ���������
    /// </summary>
    public enum Rank
    {
        /// <summary>
        /// �������
        /// </summary>
        Rookie = 0,

        /// <summary>
        /// �������
        /// </summary>
        Champion = 1,

        /// <summary>
        /// ������
        /// </summary>
        Ultimate = 2,

        /// <summary>
        /// ����
        /// </summary>
        Mega = 3
    }


    /// <summary>
    /// ��� ��������
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// �����
        /// </summary>
        Virus,

        /// <summary>
        /// ����
        /// </summary>
        Data,

        /// <summary>
        /// �������
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
using System;

namespace DataBase
{

    /// <summary>
    /// ������� ����
    /// </summary>
    public class Domain
    {
        public Domain(string nameRus, string nameEng)
        {
            NameRus = nameRus;
            NameEng = nameEng;
        }

        public string NameRus { get; set; }
        public string NameEng { get; set; }
    }
}
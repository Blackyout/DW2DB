using System;

namespace DataBase
{
    public class Domain
    {
        public Domain()
        {
        }

        public Domain(string nameRus, string nameEng)
        {
            NameRus = nameRus;
            NameEng = nameEng;
        }


        public Guid Id { get; set; }
//
//        public string Id => NameEng;
        public string NameRus { get; set; }
        public string NameEng { get; set; }
    }
}
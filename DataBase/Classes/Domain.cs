using System;

namespace DataBase
{
    public class Domain
    {
        public Domain()
        {
            Id = Guid.NewGuid();
        }

        public Domain(string nameRus, string nameEng)
        {
            Id = Guid.NewGuid();
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
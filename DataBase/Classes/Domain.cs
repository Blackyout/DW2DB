namespace DB
{
    public class Domain
    {
        public Domain(string nameRus, string nameEng)
        {
            NameRus = nameRus;
            NameEng = nameEng;
        }

        public string Id => NameEng;
        public string NameRus { get; set; }
        public string NameEng { get; set; }
    }
}
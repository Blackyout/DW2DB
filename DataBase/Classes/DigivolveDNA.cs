namespace DataBase
{
    public class DigivolveDNA
    {
        public DigivolveDNA(string digimonParent1Id, string digimonParent2Id, string digimonChildId)
        {
            DigimonParent1Id = digimonParent1Id;
            DigimonParent2Id = digimonParent2Id;
            DigimonChildId = digimonChildId;
        }

        public string DigimonParent1Id { get; set; }
        public string DigimonParent2Id { get; set; }
        public string DigimonChildId { get; set; }
    }
}
using System;
using System.Collections.Generic;

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

        public DigivolveDNA(string digimonParent1Id, string digimonParent2Id, string digimonChildId, bool mutation)
        {
            DigimonParent1Id = digimonParent1Id;
            DigimonParent2Id = digimonParent2Id;
            DigimonChildId = digimonChildId;
            Mutation = mutation;
        }


        public string DigimonParent1Id { get; set; }
        public string DigimonParent2Id { get; set; }
        public string DigimonChildId { get; set; }

        public bool Mutation { get; set; }

    }
}
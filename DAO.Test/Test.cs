using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Xunit;


namespace DAO.Test
{
    


    public class Tests
    {
        [Fact]
        public void EntityTest()
        {

            foreach (var digivolve in DataBase.DB.Digivolves)
            {
                var from = DataBase.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonFromId);
                var to = DataBase.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonToId);
                if (from == null)
                {
                    Console.WriteLine(digivolve.DigimonFromId);
                }
                if (to == null)
                {
                    Console.WriteLine(digivolve.DigimonToId);
                }
            }

            
        }

    }
}

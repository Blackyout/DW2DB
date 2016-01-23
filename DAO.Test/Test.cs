using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Xunit;

namespace DAO.Test
{
    public class Tests
    {
        [Fact]
        public void EntityTest()
        {

            foreach (var digivolve in DB.DB.Digivolves)
            {
                var from = DB.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonFromId);
                var to = DB.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonToId);
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

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataBase.DW2DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataBase.DW2DBContext context)
        {
            var digimons = DB.Digimons;

            var digivolves = DB.Digivolves;

            var metalGreymon = digimons.FirstOrDefault(x => x.NameEng == "MetalGreymon");
            var greymon = digimons.FirstOrDefault(x => x.NameEng == "Greymon");
            var agumon = digimons.FirstOrDefault(x => x.NameEng == "Agumon");

            greymon.DigivolesTo = new List<Digivolve>();
            greymon.DigivolesFrom = new List<Digivolve>();

            var digivolvesTo = digivolves.FirstOrDefault(x => x.DigimonFromId == "Greymon");
            var digivolvesFrom = digivolves.FirstOrDefault(x => x.DigimonToId == "Greymon");

            digivolvesTo.DigimonFrom = greymon;
            digivolvesTo.DigimonTo = metalGreymon;

            digivolvesFrom.DigimonFrom = agumon;
            digivolvesFrom.DigimonTo = greymon;

            greymon.DigivolesFrom.Add(digivolvesFrom);
            greymon.DigivolesTo.Add(digivolvesTo);





            context.Digimons.Add(greymon);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

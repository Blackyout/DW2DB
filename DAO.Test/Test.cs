using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Xunit;


namespace DAO.Test
{
    public class Tests
    {

        private static byte[] ConvertImageToByteArray(string fileName)
        {
            Bitmap bitMap = new Bitmap(fileName);
            ImageFormat bmpFormat = bitMap.RawFormat;
            var imageToConvert = Image.FromFile(fileName);
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, bmpFormat);
                return ms.ToArray();
            }
        }



        private static void Fill(DW2DBContext context)
        {
            var start = DateTime.Now;


            var digimons = DBStatic.Digimons;

            var digivolves = DBStatic.Digivolves;
            DBStatic.Fill();

            var digivolvesDna = DBStatic.DigivolvesDNA;

            var toDB = digimons;//.Where(x => x.NameEng == "Greymon" || x.NameEng == "Agumon" || x.NameEng == "Betamon");


            foreach (var digimon in toDB)
            {
                Console.WriteLine("Begin adding " + digimon.NameEng);



                digimon.DigivolesFrom = new List<Digivolve>();
                digimon.DigivolesTo = new List<Digivolve>();
                digimon.Locations = new List<Location>();
                digimon.Skills = new List<Skill>();
                digimon.DigivolveDnas = new List<DigivolveDNA>();

                var path = Directory.GetCurrentDirectory() + "\\" + "DigimonPic" + "\\" + digimon.NameEng;
                if (File.Exists(path + ".jpg"))
                    path += ".jpg";
                if (File.Exists(path + ".jpeg"))
                    path += ".jpeg";
                if (File.Exists(path + ".png"))
                    path += ".png";
                if (File.Exists(path + ".gif"))
                    path += ".gif";



                digimon.Picture = ConvertImageToByteArray(path);




                //Пишем локации
                var locations = DBStatic.Locations.Where(x => x.DigimonId == digimon.NameEng);

                foreach (var location in locations)
                {
                    location.Digimon = digimon;
                    digimon.Locations.Add(location);
                }

                //Пишем скиллы
                var skills = DBStatic.Skills.Where(x => x.DigimonId == digimon.NameEng);

                foreach (var skill in skills)
                {
                    skill.Digimon = digimon;
                    digimon.Skills.Add(skill);
                }

                //Пишем превращения

                digimon.DigivolesTo = new List<Digivolve>();
                digimon.DigivolesFrom = new List<Digivolve>();

                var digivolvesTo = digivolves.Where(x => x.DigimonFromId == digimon.NameEng);
                var digivolvesFrom = digivolves.Where(x => x.DigimonToId == digimon.NameEng);

                foreach (var digivolve in digivolvesTo)
                {
                    digivolve.DigimonFrom = digimon;
                    digivolve.DigimonTo = digimons.FirstOrDefault(x => x.NameEng == digivolve.DigimonToId);
                }

                foreach (var digivolve in digivolvesFrom)
                {
                    digivolve.DigimonTo = digimon;
                    digivolve.DigimonFrom = digimons.FirstOrDefault(x => x.NameEng == digivolve.DigimonFromId);
                }


                digimon.DigivolesFrom.AddRange(digivolvesFrom);
                digimon.DigivolesTo.AddRange(digivolvesTo);

                context.Digimons.Add(digimon);
            }



            foreach (var digivolveDna in digivolvesDna)
            {
                var digimonDnaParent1 = new DigivolveDNAParent();
                var digimonDnaParent2 = new DigivolveDNAParent();
                //var digimonDnaParent2 = new DigivolveDNAParent();

                digimonDnaParent1.Parent =
                    digimons.FirstOrDefault(x => x.NameEng == digivolveDna.DigimonParent1Id);
                digimonDnaParent2.Parent =
                    digimons.FirstOrDefault(x => x.NameEng == digivolveDna.DigimonParent2Id);

                digivolveDna.Parents = new List<DigivolveDNAParent>() { digimonDnaParent1, digimonDnaParent2 };

                digivolveDna.Result = digimons.FirstOrDefault(x => x.NameEng == digivolveDna.DigimonChildId);
                // MessageBox.Show(digivolveDna.Result.NameEng);
                context.DigivolveDnas.Add(digivolveDna);
            }

            foreach (var digimon in toDB)
            {
                digimon.DigivolveDnas = digivolvesDna.Where(x => x.DigimonChildId == digimon.NameEng).ToList();
            }


            context.SaveChanges();

            var finish = DateTime.Now;
            Console.WriteLine("All time = " + (finish - start));

        }

        [Fact]
        public void FillTest()
        {
            using (DB db = new DB())
            {
                var date = DateTime.Now;

                Fill(db.dw2DbContext);

                var date1 = DateTime.Now;

                Console.WriteLine(date1 - date);
            }
        }



        [Fact]
        public void DAOTest()
        {
            using (DB db = new DB())
            {
                var date = DateTime.Now;

                var digimon = db.dw2DbContext.Digimons.ToList();

                foreach (var digimon1 in digimon)
                {
                    Console.WriteLine(digimon1.NameEng);
                }


            }

        }


    }
}

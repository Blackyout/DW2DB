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
using System.Diagnostics;

namespace DAO.Test
{
    public class Tests
    {
        [Fact]
        public void SpeedTest()
        {
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            DBStatic.Fill();
            watch1.Stop();
            Console.WriteLine(watch1.Elapsed);
        }







        [Fact]
        public void Main()
        {
            string[] z =
                new string[] {"asdfasdfasdfbc",
                    "afsdfsdfsdfasdfasdfaasdf",
                    "dfsdffsdf",
                    "adfassdfdfasdf",
                    "adfasfddfasdf",
                    "adfassdfaasddffasdf",
                    "adfassdfdaafasdf",
                    "adfasfasdfdfsasdf",
                    "adfasfsdsdfasdf",
                    "adfassddsfasdf",
                    "adfassdfasdf",
                    "adfasfsddfasdf",
                    "adfasdfsddfdfasdf",
                    "adfadfasdfasdf",
                    "adfadfsdfssdfasdf",
                    "adfasdfasdfssdfasdf",
                    "adfasdfasdfssdffdfsdfsdasdf",
                    "adfasdfasdfssdfafasdfsdfsdfassdf",
                    "adfasdfasdfasdfdsfdfddfasdfssdfasdf",
                    "dsdfsdfdf",
                    "adfasddfsfasdfssdfasdf",
                    "df",
                    "s",
                    "adfasdffsasdfssdfasdf",
                    "as",
                    "adfasdfdfasdfasdfssdfasdf",
                    "adfasdfasdfssdfasdf",
                    "adfasdfsadsfsffasdfssdfasdf",
                    "adfasddsfsfasdfssdfasdf",
                    "adfasddsasdfssdfasdf",
                    "s",
                    "sdf",
                };//воткнуть любой набор строк  };
            Stopwatch watch1 = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();
            Stopwatch watch3 = new Stopwatch();
            Stopwatch watch4 = new Stopwatch();

            HashSet<String> str = new HashSet<String>();
            HashSet<int> dig = new HashSet<int>();
            List<String> str1 = new List<String>();
            List<int> dig1 = new List<int>();
            foreach (var s in z)
            {
                str.Add(s);
                str1.Add(s);
                dig.Add(s.GetHashCode());
                dig1.Add(s.GetHashCode());
            }

            int a = 7;
            watch2.Start();
            for (int n = 0; n < 10000000; n++)
                if (dig.Contains(z[0].GetHashCode()))
                    a--;
            watch2.Stop();
            watch1.Start();
            for (int n = 0; n < 10000000; n++)
                if (str.Contains(z[0]))
                    a++;
            watch1.Stop();


            watch3.Start();
            for (int n = 0; n < 10000000; n++)
                if (dig1.Contains(z[0].GetHashCode()))
                    a--;
            watch3.Stop();
            watch4.Start();
            for (int n = 0; n < 10000000; n++)
                if (str1.Contains(z[0]))
                    a++;
            watch4.Stop();


            Console.WriteLine(string.Format("str {0} int {1} a {2}", watch1.Elapsed, watch2.Elapsed, a));
            Console.WriteLine(string.Format("str {0} int {1} a {2}", watch4.Elapsed, watch3.Elapsed, a));
           // Console.ReadKey();
        }








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
            var temp = DateTime.Now;
            DBStatic.Fill();
            Console.WriteLine("LoadTime = ", DateTime.Now - temp);
            var digivolvesDna = DBStatic.DigivolvesDNA;

            var toDB = digimons;//.Where(x => x.NameEng == "Greymon" || x.NameEng == "Agumon" || x.NameEng == "Betamon");

            //return;

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

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
            DNATables.CalculateAllDNAOptions();
            watch1.Stop();
            Console.WriteLine(watch1.Elapsed);
        }


        [Fact]
        public void AllOptionsTest()
        {
           var dnas = DNATables.GetAllOptions("Veemon");
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

    }
}

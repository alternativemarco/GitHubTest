using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hogy hívnak? ");
            String nev = Console.ReadLine();
            Console.WriteLine("Oh, milyen szép név a " + nev + "!");
            Console.WriteLine("Szerecc programozni?");
            String v = Console.ReadLine();
            if(v.ToLower() == "igen")
            {
                Console.WriteLine("Jaj de jó, mi nagyon jó barátok leszünk!");
            }
            else
            {
                Console.WriteLine("Hát akko kabe!");
            }

            //TODO: csijjag
            Console.ReadKey();
        }
    }
}

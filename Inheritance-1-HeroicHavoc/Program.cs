using Inheritance_1_HeroicHavoc.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1_HeroicHavoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Heroic Havoc!");

            //initializing the classes:
            Barbaar barbaar = new Barbaar(99, 99, "Bjorn Ironsidekick", 99);
            Goblin goblin = new Goblin(45, 50, "Snotgurgle the Snotty", 15);
            Heks heks = new Heks(35, 10, "Hagatha Hubblebubble", 20);
            Console.WriteLine(barbaar);
            Console.WriteLine(goblin);
            Console.WriteLine(heks);
            //initialize Troops List:
            List<Troep> troops = new List<Troep>();
            troops.Add(barbaar);
            troops.Add(goblin);
            troops.Add(heks);
            //for-each loop to check data:
            foreach (Troep t in troops)
            {
                Console.WriteLine(t);
            }

        }
    }
}

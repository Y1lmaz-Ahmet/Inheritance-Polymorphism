using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1_HeroicHavoc.src
{
    internal class Barbaar : Troep
    {
        //inheritance Troep class in Barbaar
        public Barbaar(double strength, int healthPoints, string name, double movementSpeed) 
            : base(strength, healthPoints, name, movementSpeed)
        {
        }
        public void GetWild()
        {
            Console.WriteLine("Drinking Super Strength potion!\nNow I am Much stronger!");
        }
        public override string ToString()
        {
            return base.ToString()+$" [Barbaar]";
        }

    }
}

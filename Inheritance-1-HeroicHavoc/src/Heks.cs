using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1_HeroicHavoc.src
{
    internal class Heks : Troep
    {
        //inheritance the props from Troep "Troop" class
        public Heks(double strength, int healthPoints, string name, double movementSpeed)
            : base(strength, healthPoints, name, movementSpeed)
        {
        }
        public void Appear()
        {
            Console.WriteLine("Here I am!");
        }
        public void Hide()
        {
            Console.WriteLine("Now you cannot see me anymore!");
        }
        public override string ToString()
        {
            return base.ToString()+$" [Heks]";
        }
    }
}

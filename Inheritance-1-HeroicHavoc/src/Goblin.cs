using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1_HeroicHavoc.src
{
    internal class Goblin : Troep
    {
        public int GatheredGoldPoints { get; set; }
        public Goblin(double strength, int healthPoints, string name, double movementSpeed) 
            : base(strength, healthPoints, name, movementSpeed)
        {
            GatheredGoldPoints = 0;
        }
        public void StealGold()
        {
            GatheredGoldPoints += 100;
            Console.WriteLine("I have stolen 100 gold!");
        }
        public override string ToString()
        {
            return base.ToString()+$" [Goblin]{GatheredGoldPoints}";
        }
    }
}

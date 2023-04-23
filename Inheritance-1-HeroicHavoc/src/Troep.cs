using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1_HeroicHavoc.src
{
    abstract class Troep
    {
        public double Strength { get; set; }
        public int HealthPoints { get; set; }
        public string Name { get; set; }
        public double MovementSpeed { get; set; }

        public Troep(double strength,int healthPoints,string name,double movementSpeed)
        {
            Strength = strength;
            HealthPoints = healthPoints;
            Name = name;
            MovementSpeed = movementSpeed;
        }
        public void Move()
        {
            Console.WriteLine($"{this.GetType()} is moving!");
        }
        public override string ToString()
        {
            return $"[Troop]:{Name}, {HealthPoints}, {Strength}, {MovementSpeed}";
        }
    }
}

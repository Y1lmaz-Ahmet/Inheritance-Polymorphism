using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___Cat_And_Dog.src
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("eating dog food!");
        }
        public new void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine("making dog noises");
        }
        public override string ToString()
        {
            return $"[dog]: {Name}";
        }
    }
}

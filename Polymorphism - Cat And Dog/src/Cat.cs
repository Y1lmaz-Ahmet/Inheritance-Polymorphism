using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___Cat_And_Dog.src
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public new void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine("Miauwww");
        }
        //we use override to indicate that we want
        //to change the implementation of the method
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Eating Mice, Yummy!");
        }
        public override string ToString()
        {
            return $"[Cat]: {Name}";
        }
    }
}

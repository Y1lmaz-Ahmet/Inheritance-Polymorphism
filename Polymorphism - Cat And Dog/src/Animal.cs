using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___Cat_And_Dog.src
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        //We use virtual when a method may (but must not) be overridden
        public virtual void MakeNoise()
        {
            Console.WriteLine("GRRRR");
        }
        //We use virtual when a method may(but must not) be overridden
        public virtual void Eat()
        {
            Console.WriteLine("eating food");
        }
        public override string ToString()
        {
            return $"[Animal]: {Name}";
        }
    }
}

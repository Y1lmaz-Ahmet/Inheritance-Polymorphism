using Polymorphism___Cat_And_Dog.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism___Cat_And_Dog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Leo");
            Console.WriteLine(animal);
            animal.Eat();
            Console.WriteLine("----------------------------");
            Dog dog = new Dog("Santa");
            Console.WriteLine(dog);
            dog.MakeNoise();
            dog.Eat();
            Console.WriteLine("-------------------------");
            Cat cat = new Cat("Snowball");
            Console.WriteLine(cat);
            cat.MakeNoise();
            cat.Eat();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            List<Animal> animals = new List<Animal>();
            animals.Add(animal);
            animals.Add(dog);
            animals.Add(cat);
            foreach (Animal a in animals)
            {
                Console.WriteLine(a);
                a.Eat();
                a.MakeNoise();
            }
            Dictionary<string,Animal> myAnimals = new Dictionary<string,Animal>();
            myAnimals.Add(animal.Name,animal);
            myAnimals.Add(dog.Name,dog);
            myAnimals.Add(cat.Name,cat);
            foreach(KeyValuePair<string,Animal> kvp in myAnimals)
            {
                Console.WriteLine(kvp.Value);
                kvp.Value.Eat();
                kvp.Value.MakeNoise();
            }
        }
    }
}

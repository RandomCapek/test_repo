using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground_TryOuts
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangernment;

            public virtual void AnimalNoise()
            {
                Console.WriteLine("*happy animal noises*");
            }
        }
        class Dog : Animal
        {
            public int numberOfPuppies;
            public string race;

            public override void AnimalNoise()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal
        {
            public bool lovesMilk;
            public string furColor;

            public override void AnimalNoise()
            {
                Console.WriteLine("Meow");
                int x = 5614866;
                Console.WriteLine(x);
            }
        }

        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.race = "golden Retriever";
            newDog.AnimalNoise();
            Console.WriteLine($"{newDog.name}, {newDog.race}");

            Cat newCat = new Cat();
            newCat.name = "Micka";
            newCat.lovesMilk = true;
            newCat.furColor = "black";
            newCat.AnimalNoise();
            Console.WriteLine($"{newCat.name} loves milk - {newCat.lovesMilk}, {newCat.furColor}");
            Console.WriteLine();

            newDog.AnimalNoise();
            newCat.AnimalNoise();

            Animal newAnimal = new Dog();
            newAnimal.AnimalNoise();

            Console.ReadKey();
        }
    }
}

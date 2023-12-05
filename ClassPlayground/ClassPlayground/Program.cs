using System;

namespace ClassPlayground
{
    internal class Program
    {
        class Human
        {
            private int age;
            public int height;
            public int weight;
            public string hairColor;
            public string eyeColor;
            public string name;

            public Human(int age, int height, int weight)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;

                hairColor = "Neznámá";
                eyeColor = "Neznámá";
                name = "Neznámé";
            }
            public Human(int age, int height, int weight, string hairColor, string eyeColor, string name)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.hairColor = hairColor;
                this.eyeColor = eyeColor;
                this.name = name;
            }

            public void PrintCharacteristics()
            {
                string printedName = name;
                if (printedName == null)
                {
                    printedName = "No Name";
                }
                Console.WriteLine($"{printedName} je starý/á {age} let, měří {height} centimetrů a váží {weight} kilo");
            }

            public float BMI()
            {
                float heightForCalc = height / 100f;
                float bmi = weight / (heightForCalc * heightForCalc);
                return bmi;
            }
            public int GetAge()
            {
                return age;
            }
            public void SetAge(int age)
            {
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Tento věk není možné zadat");
                }
                else
                {
                    this.age = age;
                }
            }
            public void SetAge(string age)
            {
                bool isNumber = int.TryParse(age, out int ageNumber);
                if (isNumber)
                {
                    SetAge(ageNumber);
                    Console.WriteLine($"Věk člověka {name} změněn na {this.age}");
                }
                else
                {
                    Console.WriteLine("Stupid, zadej číslo troubo");
                }
            }
        }

        static void Main(string[] args)
        {
            Human human1 = new Human(32, 165, 65);

            human1.PrintCharacteristics();

            Human human2 = new Human(18, 205, 90, "Brown", "Blue", "Lojza");

            human2.PrintCharacteristics();
            float bmi = human2.BMI();   // bud to napisu takhle
            Console.WriteLine($"{human2.name} má BMI: {bmi}"); // a takhle

            Human human3 = new Human(10, 130, 80);
            Console.WriteLine($"Dítě má BMI {human3.BMI()}"); // nebo jenom takhle

            Console.WriteLine(human1.GetAge());
            human1.SetAge(50);
            Console.WriteLine(human1.GetAge());
            human1.SetAge(300);
            human1.SetAge("20");
            human1.PrintCharacteristics();
            human1.SetAge("Hahaha");
            human1.PrintCharacteristics();

            Class1 newCladdInstance = new Class1();

            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = { 10, 20, 30, 40, 50, 60 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Vypsání for cyklem:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Vypsání foreachem:");

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            float sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                //sum = sum + myArray[i];       je to to samé ;)
                sum += myArray[i]; // nebo: -=, *=, /= 
            }
            Console.WriteLine("");
            Console.WriteLine("Suma je: " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            float average = sum / myArray.Length;
            Console.WriteLine("Průměr je: " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            max = myArray.Max();
            Console.WriteLine("Maximum je: " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = int.MaxValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                    //myArray [i] je nove minimum
                }
            }

            /*min = myArray.Min();                              --> slo by, ale prej je to moc easy :D
            Console.WriteLine("Minimum je: " + min);*/

            Console.WriteLine("Minimum je: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("");
            Console.WriteLine("Napiš hledané číslo:");
            int userNumber = int.Parse(Console.ReadLine());
            bool foundNumber = false;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (userNumber == myArray[i])
                {
                    foundNumber = true;
                    Console.WriteLine($"Hledané číslo {userNumber} je na indexu: {i}");
                    break;
                }
            }
            if (foundNumber == false)
            {
                Console.WriteLine($"Hledané číslo {userNumber} v seznamu neexistuje!");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.

            Console.WriteLine("");
            Console.WriteLine("Stiskni cokoli pro ukončení ;)");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePrepNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HomePrepNumber1"; // titulek konzole :-)
            // Načti integerové číslo od uživatele (nekontroluj, že to zadal správně)
            // K načtení využij toto: https://www.tutorialspoint.com/chash-int-parse-method
            Console.ForegroundColor = ConsoleColor.Blue; // koukal jsem na ytb video a prislo mi to cool :D
            Console.WriteLine("Zadávání čísel");
            Console.ResetColor(); // tohle zkousim poprvy :D
            Console.Write("Zadej první číslo: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Načti druhé integerové číslo od uživatele (zase nekontroluj)
            Console.Write("Zadej druhé číslo: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Následující proměnné si vždycky vypiš pomocí Console.WriteLine(nazevPromenne)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vypsání čísel");
            Console.ResetColor();
            Console.WriteLine("První číslo: " + number1);
            Console.WriteLine("Druhé číslo: " + number2);
            Console.WriteLine();

            // Vypočítej součet čísel a ulož ho do proměnné, kterou pojmenuješ sum
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Početní operace");
            Console.ResetColor();
            int sum = number1 + number2;
            Console.WriteLine("Součet je: " + sum);

            // Vypočítej rozdíl čísel a ulož ho do proměnné, kterou pojmenuješ sub
            int sub = number1 - number2;
            Console.WriteLine("Rozdíl je: " + sub);

            // Vypočítej násobek čísel a ulož ho do proměnné multiply
            int multiply = number1 * number2;
            Console.WriteLine("Součin je: " + multiply);

            // Vypočítej podíl čísel a ulož ho do proměnné divide
            float divide = (float)number1 / number2;
            Console.WriteLine("Podíl je: " + divide);

            // Zkus nejdřív zadat taková dvě čísla, která ti vrátí celé číslo jako podíl
            // Potom zkus zadat čísla, která ti vrátí destinné číslo a zamysli se nad tím,
            // co ti vrátilo dělení dvou integerů (zaokrouhluje to dolů) - PRAVDA!
            // Předělej proměnnou divide na float a v dělení zkonvertuj alespoň jednu z proměnných (dělenec nebo dělitel) na float (což uděláš tím, že před proměnnou napíšeš do závorek float, vypadá to takhle: (float)integerovaPromenna.) Tím docílíš toho, že se výsledek nezaokrouhlí.
            // to prekonvertovani jsem uz umel :))))))
            // Vypočítej mocninu a ulož si ji.
            double pow1 = Math.Pow(number1, 2); // prej musi bejt dabl mi to psalo, zkusil jsem float a nefunguje, asi nevim proc :(
            double pow2 = Math.Pow(number2, 2);
            Console.WriteLine($"Druhé mocniny jsou: {pow1} a {pow2}");

            // Vypočítej odmocninu a ulož si ji. Použij k tomu tohle: https://www.tutorialspoint.com/math-sqrt-method-in-chash
            double sqrt1 = Math.Sqrt(number1);
            double sqrt2 = Math.Sqrt(number2);
            Console.WriteLine($"Druhé odmocniny jsou: {sqrt1} a {sqrt2}");
            Console.WriteLine();

            // Udělej if, podle kterého zjistíš, jestli je proměnná sum kladná, nebo záporná, a vypiš tuhle informaci do konzole uživateli.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ifs");
            Console.ResetColor();
            if (sum > 0)
            {
                Console.WriteLine("Součet je kladný");
            }
            else if (sum < 0)
            {
                Console.WriteLine("Součet je záporný");
            }
            else
            {
                Console.WriteLine("Součet je 0");
            }

            // Udělej if, podle kterého zjistíš, jestli je proměnná sub větší, nebo menší než proměnná multiply a zase to vypiš.
            if (sub > multiply)
            {
                Console.WriteLine("Rozdíl je větší než součin");
            }
            else if (sub < multiply)
            {
                Console.WriteLine("Rozdíl je menší než součin");
            }
            else
            {
                Console.WriteLine("Rozdíl je stejný jako součin");
            }

            // Udělej if, podle kterého zjistíš, jestli je sum větší, než sub a zároveň multiply je větší, než divide (Znak pro “a zároveň” v podmínce je &&.) Vypiš informaci, jestli to (ne)platí do konzole uživateli.
            if (sum > sub && multiply > divide)
            {
                Console.WriteLine("SOUČET je větší než ROZDÍL a SOUČIN je větší než PODÍL"); // plati oboji naraz, protoze && = a zaroven
            }
            else
            {
                Console.WriteLine("SOUČET není větší než ROZDÍL nebo SOUČIN není větší než PODÍL"); // snad je to ze jedno z toho muze platit zejo?!
            }

            // Uživatel bude do konzole psát na každý řádek libovolné číslo, dokud nenapíše místo čísla “stop”. Napiš while/for cyklus, ve kterém tohle načítání realizuješ.

            for (int i = 0; i < 9; i++)
            {
                string arrayNumbers = Console.ReadLine();
                if (arrayNumbers == "stop")
                {
                    break;
                }
                else
                {
                    Convert.ToInt32(arrayNumbers);
                }
            }

            // Čísla ukládej za sebou do integerového pole, které si nadefinuj libovolně velké.
            int[] array = new int[10];
            
            // Dávej ovšem pozor, aby uživatel nemohl zadat více proměnných, než je tvoje velikost pole.

            // Po číslech bude uživatel psát na každý řádek operaci (zatím jenom + a -). Ukládej si operace do charového pole stejným principem, jako sis ukládal čísla s tím, že operací musí být o 1 méně, než je čísel.

            // Vypočítej rovnici, kterou ti zadáním čísel a operací uživatel zadal. Když zadal čísla 5, 6 a 3 a operace + a -, znamená to rovnici 5 + 6 - 3. Výsledek vypiš uživateli do konzole.

            // Rozšíř operace o * a /. Dávej pozor na to, že násobení a dělení má přednost před sčítáním a odčítáním.

            Console.ReadKey();
        }
    }
}

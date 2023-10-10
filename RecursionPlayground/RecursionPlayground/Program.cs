using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.
            if (n == 1)
            {
                Console.WriteLine("Ukoncovaci podminka, jsme na 1");
                return 1;
            }
            Console.WriteLine($"Jeste nejsem v 1, jdu do {n - 1}");
            int nFactorial = n * Factorial(n - 1);
            Console.WriteLine($"Pro {n} je nFaktorial {nFactorial}");
            return nFactorial; // TODO: Uprav, aby Factorial vracel spravnou hodnotu.
        }

        static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int nFibonacci = Fibonacci(n - 1) + Fibonacci(n - 2);
            // TODO: Urci ukoncovaci podminku pro Fibonacciho a zavolej Fibonacci zevnitr se spravnym parametrem / vypoctem.
            return nFibonacci; // TODO: Uprav, aby Fibonacci vracel spravnou hodnotu.
        }
    }
}

using System;
using System.Collections.Generic;

namespace MaturitaNanecisto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
                Console.Write(array[i] + " ");
            }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine('\n');
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            string[] obsah = { "max", "ondra", "buh" };
            List<string> list2 = new List<string>(obsah);
            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            list.Remove(2);
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list2.RemoveAt(1);
            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            list2.Insert(1, "ondra");
            Console.WriteLine();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }


            List<int> list3 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list3.Add(rnd.Next(1, 20));
            }
            Console.WriteLine();
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);
            }
            list3.Sort();
            Console.WriteLine();
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);
            }
            Console.Write("\n");

            // 2D
            int[,] array2D = new int[5, 5];
            for (int i = 0;i < array2D.GetLength(0); i++)
            {
                for (int j = 0;j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = rnd.Next(1,10);
                    Console.Write(array2D[i, j] + " ");
                }
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
}

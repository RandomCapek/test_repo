using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] my2DArray = new int[5, 5]; // [,] pro 2D pole | [,,] by bylo pro 3D pole
            int numberToAdd = 1;
            for (int i = 0; i < my2DArray.GetLength(0); i++) // GetLenght, aby mi nebral cele pole o 25 clenech ale jenom tech 5 radku
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++) //GetLenght stejne, ale pro sloupce
                {
                    my2DArray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2DArray[i, j] + " "); //i jsou radky, j jsou sloupce
                }
                Console.Write("\n"); // \n mi udela novy radek
            }


            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            for (int j = 0; j < my2DArray.GetLength(0); j++)
            {
                Console.Write(my2DArray[nRow, j] + " ");
            }
            Console.WriteLine("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                Console.Write(my2DArray[i, nColumn] + " ");
            }
            Console.WriteLine("\n");


            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 1;               //int xFirst, yFirst, xSecond, ySecond;
            //int first = my2DArray[xFirst,yFirst];
            //int second = my2DArray[xSecond,ySecond];

            /*
            int temp = my2DArray[xFirst, yFirst];
            my2DArray[yFirst, yFirst] = my2DArray[xSecond, ySecond];
            my2DArray[xSecond, ySecond] = temp;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
            */

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int[] tempArray = new int[5];
            //zkopirovani nRowSwap radku do pomocneho pole tempArray
            for (int j = 0; j < my2DArray.GetLength(0); j++)
            {
                tempArray[j] = my2DArray[nRowSwap, j];
            }

            /*
            //prepsani nRowSwap radku radkem mRowSwap
            for (int j = 0; j < my2DArray.GetLength(0); j++)
            {
                 my2DArray[nRowSwap, j] = my2DArray[mRowSwap, j];
            }

            //prepsani mRowSwap radku pomocnym polem tempArray
            for (int j = 0; j < my2DArray.GetLength(0); j++)
            {
                my2DArray[mRowSwap, j] = tempArray[j];
            }
            */

            //vypsání do konzole
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int[] tempArrayColumn = new int[5];
            //zkopirovani nColSwap sloupce do pomocneho pole tempArrayColumn
            for (int i = 0; i < my2DArray.GetLength(1); i++)
            {
                tempArrayColumn[i] = my2DArray[i, nColSwap];
            }
            /*
            //prepsani nColSwap sloupce sloupcem mColSwap
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
            }
            //prepsani mColSwap sloupce pomocnym polem tempArrayColumn
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                my2DArray[i, mColSwap] = tempArrayColumn[i];
            }
            */
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            /*
             * for (int i = 0; i <= my2DArray.GetLength(0) / 2; i++)
            {
                int temp = my2DArray[i, i];
                int reversedIndex = my2DArray.GetLength(0) - i - 1;
                my2DArray[i, i] = my2DArray[reversedIndex, reversedIndex];
                my2DArray[reversedIndex, reversedIndex] = temp;
            }
            */
            //vypsání do konzole
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");


            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(my2DArray[i, my2DArray.GetLength(0) - i - 1] + " ");
            }
            for (int i = 4; i >= my2DArray.GetLength(0) / 2; i--) //4,3,2
            {
                int temp = my2DArray[i, my2DArray.GetLength(0) - i - 1];
                int j = my2DArray.GetLength(0) - i - 1;
                my2DArray[i, j] = my2DArray[j,i];
                my2DArray[j,i] = temp;
            }
            //vypsání do konzole
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}

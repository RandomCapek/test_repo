using System;
using System.Net.Http.Headers;

namespace Maticové_operace
{
    internal class Program
    {
        //vypsani do konzole
        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // projde vsechny radky
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // projde vsechny sloupce
                {
                    Console.Write(matrix[i, j] + " "); // to actual vypsani
                }
                Console.Write("\n"); // enter
            }
            //Console.WriteLine(); // vynechany radek
        }
        //nasobeni
        static void Multi(int[,] matrix, int scalar) // matrix je matice, kterou násobím; scalarem násobím matici
        {
            int rows = matrix.GetLength(0); // proměnná pro řádky
            int columns = matrix.GetLength(1); // proměnná pro sloupce

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= scalar; // samotné násobení
                }
            }
        }
        //generator nahodnych cisel
        static Random random = new Random();
        //transpozice
        static int[,] Trans(int[,] matrix)
        {
            int Row = matrix.GetLength(0); // radky
            int Column = matrix.GetLength(1); // sloupce
            int[,] transArray = new int[Column, Row]; // nove (pomocne) pole pro ulozeni prevraceneho pole
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    transArray[j, i] = matrix[i, j]; // samotná transpozice
                }
            }
            return transArray; // vrati mi transArray (transpozicne prehozenou matici)
        }
        //nasobeni dvou matic
        static int[,] Multi2(int[,] matrix1, int[,] matrix2) // z velke casti podle ChatGPT, vysledek mi to nejaky haze, ale nevim jak moc je spravny nebo spatny :D
        {
            int row1 = matrix1.GetLength(0);
            int col1 = matrix1.GetLength(1);
            int row2 = matrix2.GetLength(0);
            int col2 = matrix2.GetLength(1);
            if (col1 != row2) // podminka, aby mi program nepadal, kdyz nebude schopen vynasovit dane dve matice
            {
                return null;
            }
            int[,] result = new int[row1, col2]; // vytvarim novou matici
            // result ma stejny pocet radku jako row1 a stejny pocet sloupcu jako col2  // tak funguje násobení matic ;)
            for (int i = 0; i < row1; i++) // prochazim radky 1. matice
            {
                for (int j = 0; j < col2; j++) // prochazim sloupce 2. matice
                {
                    int sum1 = 0; // nastavim si "pocitadlo", priradim mu hodnotu 0
                    for (int k = 0; k < col1; k++) // prochazim sloupce 1. matice a radky 2. matice a postupne nasobim a scitam, viz. o trochu dole
                    {
                        sum1 += matrix1[i, k] * matrix2[k, j]; // do pocitadla sum1 se postupne pridavaji hodnoty, ktere dostanu vynasobenim prvku z tech dvou matic
                    }
                    result[i, j] = sum1; // dosadim vyslou hodnotu po souctu do meho vysledne result pole
                }
            }
            return result; // musi mi to neco vracet ;)
        }
        static void Main(string[] args) // Main
        {
            //začátek/grafika
            Console.WriteLine();
            Console.WriteLine("Vítej v programu MATICE!");
            Console.WriteLine();
            Console.WriteLine("Zadej počet řádků");
            string a = Console.ReadLine();  // precte vstup jako string
            int Row = int.Parse(a); // konvertuje do intu
            Console.WriteLine("Zadej počet sloupců");
            string b = Console.ReadLine(); // -||-
            int Column = int.Parse(b); // -||-
            Console.Write("\n");

            Console.WriteLine("Tvoje původní matice je:");
            int[,] firstArray = new int[Row, Column]; // [,] = 2D pole; tímto vytvořím 2D pole s velikostí, co zadal uživatel

            int numberToAdd = 1;    // zkopirovano z my2DArray 
            for (int i = 0; i < firstArray.GetLength(0); i++) // GetLenght uz znam (0) Rows
            {
                for (int j = 0; j < firstArray.GetLength(1); j++) // (1) Columns
                {
                    firstArray[i, j] = numberToAdd;
                    numberToAdd++; // prida 1 (++) do hodnoty prvku (proto jsou v matici cisla 1,2,3,...)
                    Console.Write(firstArray[i, j] + " "); // i = Row, j = Column
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.WriteLine("OPERACE S MATICÍ:");
            //součet prvků v matici (navíc)
            int soucet = 0; // pocitadlo pro soucet, do ktereho se postupne pridavaji hodnoty
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    soucet += firstArray[i, j]; // += pridava hodnoty matice na indexech i a j do pocitadla soucet
                }
            }
            Console.WriteLine($"Součet prvků je: {soucet}");

            //průmer prvků v matici (stejny jako soucet akorat vydeleny firstArray.Length (neboli poctem prvku v matici -> aritmeticky prumer ;D)
            Console.WriteLine($"Průměr prvků je: {soucet / (double)firstArray.Length}"); // (double) pretypuje na desetinne cislo

            //počet sudých členů
            int pocetSudych = 0; //pocitadlo
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    if (firstArray[i, j] % 2 == 0) // zjistim, jestli je cislo (na indexu, na kterem zrovna jsem) sude
                    {
                        pocetSudych++; //pokud ano, pridam 1 (++) do pocitadla 
                    }
                }
            }
            Console.WriteLine($"Počet sudých členů je: {pocetSudych}");

            //počet lichých členů 
            int pocetLichych = 0; //pocitadlo
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    if (firstArray[i, j] % 2 != 0) // != je negace pro ==
                    {
                        pocetLichych++;
                    }
                }
            }
            Console.WriteLine($"Počet lichých členů je: {pocetLichych}");

            //celkový počet členů
            Console.WriteLine($"Celkový počet členů je: {firstArray.Length}"); //.Length vezme velikost pole jako hodnotu, tim padem pocet clenu (5*5 pole = 5*5 prvku)
            Console.WriteLine();

            //prohození prvků
            Console.WriteLine("Prohozené prvky:");
            int[,] tempArray1 = (int[,])firstArray.Clone(); // naklonuju si puvodni pole
            int xFirst = 0;
            int yFirst = 0;                 // prohození mnou předem určených (souřadnic) prvků
            int xSecond = 1;                // prohazuji prvni dve cisla na hlavni diagonale
            int ySecond = 1;
            int first = tempArray1[xFirst, yFirst];    // nefunguje u moc malych poli, kde neni co prohrazovat
            int second = tempArray1[xSecond, ySecond]; // -||-
            int temp = tempArray1[xFirst, yFirst]; // pomocne pole temp naplnim prvnim prvkem
            tempArray1[yFirst, yFirst] = firstArray[xSecond, ySecond]; // prvek Second dam do prazdneho mista, kde byl driv prvni prvek
            tempArray1[xSecond, ySecond] = temp; // vratim prvni prvek ulozeny do pomocneho pole na souradnice Second
            //vypsání do konzole
            for (int i = 0; i < tempArray1.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray1.GetLength(1); j++)
                {
                    Console.Write(tempArray1[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //prohození řádků
            Console.WriteLine("Prohozené řádky:");
            int[,] tempArray2 = (int[,])firstArray.Clone(); // klon
            int nRowSwap = 0; // n radek
            int mRowSwap = 1; // m radek
            int[] tempArrayRow = new int[Math.Max(Row, Column)]; // Math.Max zmeni velikost pomocneho pole, jinak by neslo napr.5*6 pole ale pouze napr.6*5, chatGPT pomohl

            for (int j = 0; j < Column; j++)
            {
                tempArrayRow[j] = tempArray2[nRowSwap, j]; // zkopirovani nRowSwap radku do pomocneho pole tempArrayRow
                tempArray2[nRowSwap, j] = tempArray2[mRowSwap, j]; // prohozeni nRowSwap s mRowSwapem (na 1. souradnici (radku))
                tempArray2[mRowSwap, j] = tempArrayRow[j]; // vraceni pomocne promenne do nyni prazdneho mRowSwap
            }
            //vypsání do konzole
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(tempArray2[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //prohození sloupců
            Console.WriteLine("Prohozené sloupce:");
            int[,] tempArray3 = (int[,])firstArray.Clone(); // klon
            int nColumnSwap = 0; // n sloupec // nadefinovane predem
            int mColumnSwap = 1; // m sloupec // -||-
            int[] tempArrayColumn = new int[Math.Max(Row, Column)]; // zase Math.Max
            for (int i = 0; i < Row; i++)
            {
                tempArrayColumn[i] = tempArray3[i, nColumnSwap]; // zkopirovani nColumnSwap radku do pomocneho pole tempArrayColumn
                tempArray3[i, nColumnSwap] = tempArray3[i, mColumnSwap]; // prohozeni nColumnSwap s mColumnSwapem (na 1. souradnici (sloupce))
                tempArray3[i, mColumnSwap] = tempArrayColumn[i]; // vraceni pomocne promenne do nyni prazdneho mColumnSwap
            }
            //vypsání do konzole
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(tempArray3[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //otočení pořadí na hlavní diagonále
            int[,] tempArray4 = (int[,])firstArray.Clone(); // klon
            int temp42 = Math.Min(Row, Column); //Math.Min pouziva minimalni rozmer z Row i z Column, takze otoceni funguje i v nectvercovem poli napr 7*5, ChatGPT pomohl
            for (int i = 0; i < temp42 / 2; i++) // tenhle cyklus mi postupne otoci vsechny cisla na hlavni diagonale
            {
                int temp4 = tempArray4[i, i]; // vlozim otaceny prvek do pomocneho pole 
                int reversedIndex = temp42 - i - 1; // vytvorim reversedIndex abych nasel prvek opacny proti tomu, ktery mam ted v pomocnem poli (ktery otacim)
                tempArray4[i, i] = tempArray4[reversedIndex, reversedIndex]; // prohodim prvek normalnich indexu s prvkem opacnych indexu
                tempArray4[reversedIndex, reversedIndex] = temp4; // vratim prvek z pomocneho pole
            }
            //vypsání do konzole
            Console.WriteLine("Otočená hlavní diagonála:");

            for (int i = 0; i < tempArray4.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray4.GetLength(1); j++)
                {
                    Console.Write(tempArray4[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //otočení pořadí na vedlejší diagonále
            int[,] tempArray5 = (int[,])firstArray.Clone(); // klon
            int temp02 = Math.Min(Row, Column);                                 // velmi podobne jako u hlavni diagonaly
            for (int i = 0; i < temp02 / 2; i++)
            {
                int temporary = tempArray5[i, temp02 - i - 1];
                int j = temp02 - i - 1;
                tempArray5[i, j] = tempArray5[j, i];
                tempArray5[j, i] = temporary;
            }
            //vypsání do konzole
            Console.WriteLine("Otočená vedlejší diagonála:");
            for (int i = 0; i < tempArray5.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray5.GetLength(1); j++)
                {
                    Console.Write(tempArray5[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //vynásobení matice číslem
            int[,] tempArray6 = (int[,])firstArray.Clone(); // klon
            Console.WriteLine("Kterým číslem chceš násobit?");
            string c = Console.ReadLine(); // davam moznost uzivateli zadat cislo, kterym budu nasobit
            int multi = int.Parse(c); // opet z textu udelam cislo (string -> int)
            Console.WriteLine($"Násobím číslem {multi}:"); // vypisu zadane cislo
            Console.WriteLine();
            Multi(tempArray6, multi); // zavolam funkci pro nasobeni
            Console.WriteLine("Vynásobená matice:");
            Print(tempArray6); // zavolam funkci pro vypsani do konzole (nepodarilo se mi to udelat bez static void Print, takze to je podle ChatGPT)

            //součet dvou matic
            int[,] secondArray = new int[Row, Column]; // vytvarim si druhou matici, kterou budu scitat s prvni (firstArray + secondArray = sumArray)
            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    secondArray[i, j] = random.Next(10); // naplni mi matici random cisly od 0 do 9 (do 10 ale bez 10)
                }
            }
            int[,] sumArray = new int[Row, Column]; //vytvorim si matici pro vysledek po souctu
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    sumArray[i, j] = firstArray[i, j] + secondArray[i, j];
                }
            }
            //vypsání do konzole (vypsal jsem i původní matici, i random naplňenou novou matici, i jejich součet)
            Console.WriteLine($"Původní matice:");
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    Console.Write(firstArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine(" plus ");
            Console.WriteLine();
            Console.WriteLine("Nová random naplněná matice:");
            for (int i = 0; i < secondArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    Console.Write(secondArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine(" rovná se ");
            Console.WriteLine();
            Console.WriteLine("Jejich součet:");
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //Rozdíl dvou matic (skoro stejný jako součet)
            int[,] thirdArray = new int[Row, Column]; // vytvarim si druhou matici, kterou budu odcitat od prvni (firstArray - thirdArray = diffArray)
            for (int i = 0; i < thirdArray.GetLength(0); i++)
            {
                for (int j = 0; j < thirdArray.GetLength(1); j++)
                {
                    thirdArray[i, j] = random.Next(10);
                }
            }
            int[,] diffArray = new int[Row, Column];
            for (int i = 0; i < diffArray.GetLength(0); i++)
            {
                for (int j = 0; j < diffArray.GetLength(1); j++)
                {
                    diffArray[i, j] = firstArray[i, j] - thirdArray[i, j];
                }
            }
            //vypsání do konzole
            Console.WriteLine($"Původní matice:");
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    Console.Write(firstArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine(" minus ");
            Console.WriteLine();
            Console.WriteLine("Nová random naplněná matice:");
            for (int i = 0; i < thirdArray.GetLength(0); i++)
            {
                for (int j = 0; j < thirdArray.GetLength(1); j++)
                {
                    Console.Write(thirdArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine(" rovná se ");
            Console.WriteLine();
            Console.WriteLine("Jejich rozdíl:");
            for (int i = 0; i < diffArray.GetLength(0); i++)
            {
                for (int j = 0; j < diffArray.GetLength(1); j++)
                {
                    Console.Write(diffArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            //transpozice matice (trochu podle chatGPT, ale pochopil jsem, jak to funguje)
            int[,] transArray2 = (int[,])firstArray.Clone(); // klon
            int[,] trans2 = Trans(transArray2); // nastavim si nove pole trans2 a pridam k nemu hodnoty transArray2 z vrchni funkce Trans
            Console.WriteLine("Původní matice:");
            Print(transArray2); // vypisu do konzole puvodni (naklonovanou) matici
            Console.WriteLine();
            Console.WriteLine("Zrcadlově převrácená matice podle hlavní diagonály:");
            Print(trans2); // vypisu do konzole transpozicne prevracenou matici
            Console.WriteLine();

            //násobení dvou matic
            int[,] tempArray7 = (int[,])firstArray.Clone(); // klon
            int[,] result2 = Multi2(tempArray7, secondArray); // zavolani funkce Multi2 -> samotneho vynasobeni matic
            //vypsání do konzole
            if (result2 != null) // pokud je matice nekompatibilni (col1 != row2) nelze nasobit, nebo aspon ja to neumim ups
            {                    // ale tohle je basically podminka, aby mi program nespadl, kdyz to nepujde vynasobit
                                 // taky je zadana nahore v Multi2
            Console.WriteLine("Tuto matici:");
            Print(tempArray7);
            Console.WriteLine();
            Console.WriteLine("Násobím touto maticí:");
            Print(secondArray);
            Console.WriteLine();
            Console.WriteLine("A výsledek násobení je:");
            Print(result2);
            }
            else // kdyz je to null, coz znamena, kdyz to nejde vynasobit
            {
                Console.WriteLine("Tyto dvě matice násobit neumím. Je mi líto :(");
            }
            //ukončení/grafika
            Console.WriteLine();
            Console.WriteLine("Díky za zčeknutí mýho supráckýho programu!");
            Console.WriteLine("Klikni na cokoli pro ukončení :)");
            Console.ReadKey();
        }
    }
}

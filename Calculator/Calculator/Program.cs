using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static bool uspesnaOperace = true;  //vzdy, kdyz je operace uspesna (true), vypise se vysledek

        static float Soucet(float x, float y)
        {
            float result = x + y;
            return result;
        }
        static float Rozdil(float x, float y)
        {
            float result = x - y;
            return result;
        }
        static float Soucin(float x, float y)
        {
            float result = x * y;
            return result;
        } 
        static float Podil(float x, float y)
        {
            if (y == 0)
            {                                           //pokud by se dělilo nulou, napiš, že to nejde
                Console.WriteLine("Nelze dělit nulou!");
                uspesnaOperace = false;                 //uspesna operace tim padem neni true, ale false
                return 0f;
            }

            float result = x / y;
            return result;
        }
        static float Mocneni(float x, float y)
        {
            float result = (float)Math.Pow(x,y); //podle chatGPT, Math.Pow ->umocneni prvniho cisla v zavorce na druhe cislo v zavorce
            return result;
        }
        static float Odmocnovani(float x, float y)
        {
            float result = (float)Math.Pow(x,1/y); //podle chatGPT, umocnovani, akorat na 1/to cislo =>odmocnovani
            return result;
        }
        static float Logaritmus(float x, float baseValue)
        {
            return (float)Math.Log(x,baseValue); //podle chatGPT, math.log jsem fakt nevedel :D
        }
        static float Sinus(float x)
        {
            double uhelVeStupnich = x; //uzivatel zada ve stupnich
            double uhelVRadianech = uhelVeStupnich * (Math.PI / 180.0); // Převod na radiány
            double sinusVysledek = Math.Sin(uhelVRadianech); //vysledek v radianech
            if (Math.Abs(sinusVysledek) < 1e-6) //nutné zaokrouhlení, aby 
            {
                return 0f;
            }
            return (float)sinusVysledek; //taky podle chatGPT, ale zadal mi to úplně špatně a předělával jsem to sám třeba dvacet minut xD
        }
        static float Cosinus(float x) //stejný jako sinus ;)
        {
            double uhelVeStupnich = x;
            double uhelVRadianech = uhelVeStupnich * (Math.PI / 180);
            double cosinusVysledek = Math.Cos(uhelVRadianech);
            if (Math.Abs(cosinusVysledek) < 1e-6) 
            {
                return 0f;
            }
            return (float)cosinusVysledek;
        }
        static float Tangens(float x)
        {
            double uhelVeStupnich = x;
            double uhelVRadianech = uhelVeStupnich * (Math.PI / 180);
            double tangensVysledek = Math.Tan(uhelVRadianech);
            if (x == 90)
            {
                Console.WriteLine(" syntax error");
                uspesnaOperace = false;
                return 0f;
            }
            if (x == 270)
            {
                Console.WriteLine(" syntax error");
                uspesnaOperace = false;
                return 0f;
            }
            return (float)tangensVysledek;
        }
        static float Cotangens(float x)
        {
            double uhelVeStupnich = x;
            double uhelVRadianech = uhelVeStupnich * (Math.PI / 180);
            double tangensVysledek = Math.Tan(uhelVRadianech);
            if (x == 0)
            {
                Console.WriteLine(" syntax error");
                uspesnaOperace = false;
                return 0f;
            }
            else if (x == 180)
            {
                Console.WriteLine(" syntax error");
                uspesnaOperace = false;
                return 0f;
            }
            else if (x == 360)
            {
                Console.WriteLine(" syntax error");
                uspesnaOperace = false;
                return 0f;
            }
            else if (Math.Abs(tangensVysledek) < 1e-6)
            {
                return 0f;
            }
            else
            {
            return (float)(1/tangensVysledek);

            }
        }
        //definuju co se má stát za operaci

                static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do floategeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            Console.WriteLine("");
            Console.WriteLine("  --------------");
            Console.WriteLine("  | KALKULAČKA |");        //úvod
            Console.WriteLine("  --------------");
            Console.WriteLine("");
            float a;
            float b;

            float result = 0f; //aby byl defaultní result 0 (na začátku, po výpočtu se změní) => úkol 5

            Console.WriteLine(" zadej prvni cislo:");
            string vstup = Console.ReadLine();

            vstup = vstup.Replace('.', ','); //uzivatel muze zadat i tecku, i carku (neboli tecka se v programu zmeni na carku, ktera funguje)

            a = float.Parse(vstup);
        

               
            
            Console.WriteLine(" zadej operaci (+,-,*,/,na,z,log,sin,cos,tg,cotg)");
            string operace = Console.ReadLine();

            if (operace == "sin")
            {
                result = Sinus(a);
            }
            else if (operace == "cos")
            {
                result = Cosinus(a);
            }
            else if (operace == "tg")
            {
                result = Tangens(a);
            }
            else if (operace == "cotg")
            {
                result = Cotangens(a);
            }
            else
                {

            Console.WriteLine(" zadej druhe cislo:");
            vstup = Console.ReadLine();

            vstup = vstup.Replace('.', ','); //uzivatel muze zadat i tecku, i carku
            b = float.Parse(vstup);

            //konvertuje string do floategeru => úkoly 2 a 3
                        
            if (operace == "+")
            {
                 result = Soucet(a, b);
            }
                else if (operace == "-")
            {
                 result = Rozdil(a, b);
            }
                else if (operace == "*")
            {
                 result = Soucin(a, b);
            }
                else if (operace == "/")
            {
                 result = Podil(a, b);      
            }
                else if  (operace == "na")
            {
                result = Mocneni(a, b);
            }
                else if (operace == "z")
            {
                result = Odmocnovani(a, b);
            }
                else if (operace == "log")
            {
                result = Logaritmus(a, b);
            }
                else
            {
                Console.WriteLine(" Něco jsi zadal špatně debílku!");
            }
            //if na každou početní operaci, odkazuje na názvy operací které jsem si definoval úplně nahoře
                     
                }
        
            if (uspesnaOperace == true)
            {

                Console.WriteLine(" vysledek je " + result); //vypíše mi výsledek
            }
            else
            {
                Console.WriteLine(" Operaci nelze vyřešit!");
            }

            Console.WriteLine(" Klikni na cokoli pro ukončení"); 

            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}

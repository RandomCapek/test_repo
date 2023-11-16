using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
<<<<<<< HEAD
    {
=======
    {        
>>>>>>> 2c35ae7177021e1116269d749c6f05a0aabaa523
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            Random rng = new Random(); //instance tridy Random pro generovani nahodnych cisel
<<<<<<< HEAD
            int skoreHrac = 0;
            int skorePocitac = 0;

            while (true)
            {
                Console.WriteLine("Vyber si(piš pouze písmeno): k=kámen, n=nůžky, p=papír, q=quit");
                string volbaHrace = Console.ReadLine().ToLower();

                if (volbaHrace == "q" || volbaHrace == "quit")
                {
                    break;
                }

                int cisloPocitace = rng.Next(1,4);
                string volbaPocitace = "";

                switch (cisloPocitace)
                {
                    case 1:
                        volbaPocitace = "kámen";
                        break;
                    case 2:
                        volbaPocitace = "nůžky";
                        break;
                    case 3:
                        volbaPocitace = "papír";
                        break;
                }

                Console.WriteLine($"Počítač si vybral: {volbaPocitace}");

                if (volbaHrace == volbaPocitace)
                {
                    Console.WriteLine("Remíza!");
                }
                else if (
                    (volbaHrace == "k" && volbaPocitace == "nůžky") ||
                    (volbaHrace == "n" && volbaPocitace == "papír") ||
                    (volbaHrace == "p" && volbaPocitace == "kámen")
                    )
                {
                    Console.WriteLine("Vyhráli jste!");
                    skoreHrac++;
                }
                else if (
                    (volbaHrace == "k" && volbaPocitace == "papír") ||
                    (volbaHrace == "n" && volbaPocitace == "kámen") ||
                    (volbaHrace == "p" && volbaPocitace == "nůžky")
                    )
                {
                    Console.WriteLine("Počítač vyhrál.");
                    skorePocitac++;
                }
                else
                {
                    Console.WriteLine("Neplatná volba! Zadej kámen(k), nůžky(n), nebo papír(p)");
                }

                Console.WriteLine($"Skóre: Hráč {skoreHrac} : {skorePocitac} Počítač");
            }
            Console.WriteLine("Konec hry, díky za hraní! <3");



=======
            int skore1 = 0;
            int skore2 = 0;
            int volba = rng.Next(1, 4);
            /*Console.WriteLine(skore1);
            Console.WriteLine(skore2);*/
            
>>>>>>> 2c35ae7177021e1116269d749c6f05a0aabaa523
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}

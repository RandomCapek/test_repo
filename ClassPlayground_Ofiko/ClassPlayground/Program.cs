﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

/*
 * TODO:
 * 1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *    Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x,y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
 * 
 * 1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.
 * 
 * 2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
 *    Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
 *                                            - holderName jako jméno osoby, které účet patří
 *                                            - currency jako měna, ve které je účet vedený
 *                                            - balance jako zůstatek na účtu
 *    Přidej třídě BankAccount tři funkce - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
 *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
 *                                                      Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
 *                                          - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
 *                                                      z jednoho účtu na druhý (opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)
 *    Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
 *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
 *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
 * 
 * 2) BONUS - Až vytvoříš BankAccount, přidej varianty funkcí výběru, vkladu a převodu s měnou jako vstupním parametrem, tedy pokud měna při vkladu/výběru (nebo měna účtu, na který se převádí)
 *            je odlišná od měny, ve které je účet veden, zohledni to a správně vynásob peníze kurzem, který najdeš na internetu. Pro uložení kurzů si můžeš udělat novou statickou třídu,
 *            ve které budeš mít public static float proměnné pojmenované podle toho, jaký kurz z jaké do jaké měny představují, a jeho hodnotu.
 *
 * 3) Vytvoř třídu Student, kterou budeme reprezentovat studenta
 *    Přidej třídě Student proměnné - year pro aktuální ročník studenta
 *                                  - id pro identifikační číslo studenta
 *                                  - subjects pro seznam předmětů studenta (bude to slovník (https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/), který bude mít jako klíč string a jako hodnotu List (https://www.geeksforgeeks.org/c-sharp-list-class/) známek)
 *                                  - name pro jméno studenta
 *    Přidej třídě Student čtyři funkce - AddSubject, která jako vstupní parametr přijme název předmětu a přidá nový klíč do subjects
 *                                      - AddGrade, která jako vstupní parametr přijme název předmětu a známku a přidá podle názvu předmětu další známku danému předmětu
 *                                      - CalculateSubjectGrade, která jako stupní parametr přijme název předmětu a spočítá průměrnou známku na vysvědčení z daného předmětu
 *                                      - CaculateTotalGrade, která spočítá studijní průměr (průměr všech známek)
 *    Přidej třídě Student konstruktor, který bude přijímat dva parametry - jméno a ročník studenta
 *                                                                        - Při jeho zavolání nastav jméno a ročník podle vstupních parametrů, id vygeneruj podobně, jako accountNumber
 *                                                                          ve tříde BankAccount, a subjects nastav na nový prázdný List
 * 
 * 3) BONUS - Až vytvoříš Student, přidej možnost mít u známek váhy. Způsob nechám na tobě, možností je víc. Můžeš celou třídu překopat na známky pouze s váhou, a nebo můžeš zachovat
 *            možnost přidávat známky bez váhy s tím, že ty budou mít nějakou výchozí váhu automaticky, a přidáš varianty funkcí na přidávání známek s váhou
 * 
 * V mainu využívej tebou naprogramované třídy a funkce, vypisuj výsledky do konzole, hraj si s tím a sleduj, co se kdy děje a co kdy jaká třída dělá.
 * Když si s něčím nebudeš vědět rady, zvedni ruku nebo na mě zavolej, já přijdu a poradím :)
 * Uděláš, co stihneš. Budeme na tom pracovat i nadále, takže se nestresuj časem a v klidu si všechno postupně rozmýšlej a piš takovým tempem, jaké je ti příjemné.
 */

namespace ClassPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Rectangle
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("RECTANGLE:");
            Console.ResetColor();
            Console.WriteLine("Zadej šířku a výšku obdélníku");
            Rectangle rect = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            rect.CalculateArea();
            rect.CalculateAspectRatio();
            Console.WriteLine("Zadej souřadnice hledaného bodu:");
            bool isInside = rect.ContainsPoints(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            if (isInside) // isInside == true  ->  to samé
            {
                Console.WriteLine("Bod LEŽÍ v obdélníku");
            }
            else
            {
                Console.WriteLine("Bod NELEŽÍ v obdélníku");
            }
            

            //BankAccount
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BANK ACCOUNT:");
            Console.ResetColor();
            Console.WriteLine("\nZadej jméno držitele a měnu účtu");
            BankAccount acc = new BankAccount(Console.ReadLine(),Console.ReadLine());
            Console.WriteLine($"        Učet klienta {acc.holderName} v měně {acc.currency}:");
            acc.RandomAccountNumber(); // OMG mam to spravne :DD --> sam a skoro bez napovedy :D
            Console.WriteLine($"        balance: {acc.balance} {acc.currency}");
            Console.Write("        Chci si poslat: ");
            acc.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"        balance: {acc.balance} {acc.currency}");
            acc.Withdraw(); // funkce Withdraw
            acc.Transfer(); // funkce transfer


            //Student
            //nefunguje
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("STUDENT:");
            Console.ResetColor();
            Student student1 = new Student();
            Console.WriteLine("Přidej nějaký předmět do listu");
            student1.AddSubjects(Console.ReadLine());
            Console.WriteLine(student1.subjects.Values);

            
            // get , set
            // get - dostávám
            // set - nastavuju
            // no shit tyvole :)


            /*
            List<int> grades = new List<int>(); // definování listu
            grades.Add(5);
            grades.Add(4);
            grades.Add(3);
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine(grades[2]);

            Dictionary<string,List<int>> subjects = new Dictionary<string,List<int>>();
            subjects["zemák"] = new List<int>();
            subjects["zemák"].Add(5);
            Console.WriteLine(subjects["zemák"][0]);
            Dictionary<string,string> nameOfDict = new Dictionary<string,string>(); // definování slovníku
            nameOfDict["apple"] = "jablko"; // zadání pro překlad
            Console.Keys; // vypíše všechny keys
            Console.Values; // vypíše všechny 
            Console.WriteLine(nameOfDict["apple"]); // vypsání do konzole
            */
            Console.ReadKey();
        }
    }
}

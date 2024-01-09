using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject
{
    internal class Player // dulezita trida hrace! (USERa)
    {
        public int balance;
        public string name;
        public string dollar; // pozdejc jsem zjistil, ze tohle vubec nepotrebuju, ale jen tak ze srandy jsem to tam nechal :D

        public Player(string name) // konstruktor pro vytvoreni hrace (USERa)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            this.name = name;
            Console.WriteLine($"Player {name} entered the game");
            balance = 200;
            dollar = "$";
            Console.WriteLine($"{name} has {dollar}{balance}");
            Console.ResetColor();
        }
        public void PlayerBalance() // vypsani balancu USERa --> mohlo by byt bez teto funkce, pouze jeden Console.WriteLine, ale IDGAF :D
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");
            Console.ResetColor();
        }
    }
}

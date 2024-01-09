using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject
{
    internal class OtherPlayers // jeste dulezitejsi trida ostatnich hracu! (botú)
    {
        public int balance;
        public string name;
        public string dollar; // pozdejc jsem zjistil, ze tohle vubec nepotrebuju, ale jen tak ze srandy jsem to tam nechal :D

        Random random = new Random();

        public OtherPlayers(string name) // konstruktor pro ostatni hrace
        {
            this.name = name;
            Console.WriteLine($"Player {name} entered the game");
            balance = 200;
            dollar = "$";
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");
        }

        public void OtherPlayersBalance() // nazev mluvi za vse
        {
            Console.WriteLine($"{name}'s balance is: {dollar}{balance}");
        }

        public void OtherPlayerInDebt() // pouha Console.WriteLine 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{name} is in debt!");
            Console.ResetColor();
        }
    }
}

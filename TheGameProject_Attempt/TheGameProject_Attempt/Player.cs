using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject_Attempt
{
    internal class Player
    {
        public int balance;
        public string name;
        public string dollar;

        public Player(string name)
        {
            this.name = name;
            Console.WriteLine($"Player {name} entered the game");
            balance = 200;
            dollar = "$";
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");
        }

        public void PlayerBalance()
        {
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");
        }
    }
}

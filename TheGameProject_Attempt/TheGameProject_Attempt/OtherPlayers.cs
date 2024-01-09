using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject_Attempt
{
    internal class OtherPlayers
    {
        public int balance;
        public string name;
        public string dollar;
        private int playerGuess; // přidáme vlastnost pro tip hráče

        public OtherPlayers(string name)
        {
            this.name = name;
            Console.WriteLine($"Player {name} entered the game");
            balance = 200;
            dollar = "$";
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");

                        //GeneratePlayerGuess(); // generujeme náhodný tip hráče
        }

        public void OtherPlayerBalance()
        {
            Console.WriteLine($"{name}'s balance is {dollar}{balance}");
        }

                        //public int PlayerGuess
                        //{
                        //    get { return playerGuess; }
                        //}

                        //private void GeneratePlayerGuess()
                        //{
                        //    Random random = new Random();
                        //    playerGuess = random.Next(1, 7); // generujeme náhodné číslo pro tip hráče
                        //    Console.WriteLine($"{name}'s guess is: {playerGuess}");
                        //}
    }
}

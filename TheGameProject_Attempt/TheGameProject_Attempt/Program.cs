using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject_Attempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "!DICE GAMBLE!";

            Game game = new Game(); // instance hry
            Player player = new Player("USER"); // instance uživatele
            Dice dice = new Dice(); // instance kostky

            Console.WriteLine();
            game.OtherPlayers(); // zavolání ostatních hráčů
            Console.WriteLine();
            game.GameStarts(); // "The game is starting..."

            while (player.balance >= 20)
            {

                Console.WriteLine("Guess the number!");
                Console.Write(" Your guess: ");
                
                int userGuess = Convert.ToInt32(Console.ReadLine());

                int diceResult = game.DiceInGame(); // získání aktuálního čísla kostky
                Console.WriteLine($"Dice rolled: {diceResult}");

                if (userGuess == diceResult)
                {
                    player.balance += 100;
                }
                else
                {
                    player.balance -= 20;
                }
                player.PlayerBalance();

            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

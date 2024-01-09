using System;

namespace TheGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DICE GAMBLE!";

            Random random = new Random(); // generator nahodnych cisel
            Game game = new Game(); // instance hry
            Player player = new Player("USER"); // instance uživatele

            Console.WriteLine();
            // vytvoření instancí ostatních hráču
            OtherPlayers player1 = new OtherPlayers("Honzik");
            OtherPlayers player2 = new OtherPlayers("Baruna");
            OtherPlayers player3 = new OtherPlayers("Martin");
            OtherPlayers player4 = new OtherPlayers("Eliska");

            Console.WriteLine();
            Console.WriteLine("The game is starting...");
            Console.WriteLine("----------------");





            while (player.balance >= 20) // while cyklus pojede, dokud bude mít uživatel alespoň $20 na účtě (balance)
            {
                Console.WriteLine("Guess the number!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Your guess: ");
                Console.ResetColor();

                int userGuess = Convert.ToInt32(Console.ReadLine()); // načte tip od uživatele
                int diceRoll = game.DiceInGame(); // ulozi aktualnihod kostky do promenne diceRoll

                if (userGuess == diceRoll) // if pro USERa, jestli vyhral/prohral, a nasledne pricteni/odecteni penez z jeho balancu
                {
                    player.balance += 100;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU GUESSED IT! :)");
                    Console.ResetColor();
                }
                else
                {
                    player.balance -= 20;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU DIDNT'T GUESS IT :(");
                    Console.ResetColor();
                }

                // vytvoreni nahodnych tipu OtherPlayers
                int guess1 = random.Next(1, 7);
                int guess2 = random.Next(1, 7);
                int guess3 = random.Next(1, 7);
                int guess4 = random.Next(1, 7);

                // ifs pro ostatni hrace (neslo mi pres jinou tridu ani funkci, takze je to ultra mess, ale funguje :D
                // jeste jsem tam nakonec pridal barvicky, jinak nez takhle to neumim, takze je to ultra mega giga zmateny, ale ja se v tom vyznam, a docela to asi i dava smysl nebo idk :D
                // kazdopadne tam mam barvicky a jsem happy :>
                // a hlavne je to o dost vic prehledny s nima si myslim :D
                // player1...
                if (guess1 == diceRoll) // if stejne jako u USERa
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player1.name} guessed: {guess1}");
                    player1.balance += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player1.name} guessed: {guess1}");
                    player1.balance -= 20;
                }
                Console.ResetColor();
                if (player1.balance < 0)
                    player1.OtherPlayerInDebt(); // funkce pro napsani, ze je hrac v dluhu a jde do minusu :D
                // player2...
                if (guess2 == diceRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player2.name} guessed: {guess2}");
                    player2.balance += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player2.name} guessed: {guess2}");
                    player2.balance -= 20;
                }
                Console.ResetColor();
                if (player2.balance < 0)
                    player2.OtherPlayerInDebt();
                // player3...
                if (guess3 == diceRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player3.name} guessed: {guess3}");
                    player3.balance += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player3.name} guessed: {guess3}");
                    player3.balance -= 20;
                }
                Console.ResetColor();
                if (player3.balance < 0)
                    player3.OtherPlayerInDebt();
                // player4...
                if (guess4 == diceRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{player4.name} guessed: {guess4}");
                    player4.balance += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player4.name} guessed: {guess4}");
                    player4.balance -= 20;
                }
                Console.ResetColor();
                if (player4.balance < 0)
                    player4.OtherPlayerInDebt();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Dice rolled: {diceRoll}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("----------------");
                player.PlayerBalance(); // vypsání balancu USERa
                Console.WriteLine("----------------");

                player1.OtherPlayersBalance(); // vypsání balanců OtherPlayers
                player2.OtherPlayersBalance();
                player3.OtherPlayersBalance();
                player4.OtherPlayersBalance();
                Console.WriteLine();
            } // konec whilu!

            // stane se, pokud player.balance je mensi nez 20
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("                                                GAME OVER!");
            Console.WriteLine("                                 You don't have enough money to play again!");
            Console.WriteLine("                                                GAME OVER!");
            Console.ResetColor();
            Console.WriteLine();
            if (player.balance > player1.balance || player.balance > player2.balance || player.balance > player3.balance || player.balance > player4.balance) // vypsání toho, jestli uživatel někoho "porazil"
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                            You beat someone!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                          You didn't beat anyone!");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}

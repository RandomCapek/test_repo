using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject_Attempt
{
    internal class Game
    {
        Random random = new Random();
        private int currentDiceNumber; // nová proměnná pro uchování aktuálního čísla kostky
        private List<OtherPlayers> players = new List<OtherPlayers>(); // seznam hráčů
        private int currentRound = 0; // proměnná pro uchování aktuálního kola

        public List<OtherPlayers> Players
        {
            get { return players; }
        }

        public int CurrentRound
        {
            get { return currentRound; }
        }

        public void OtherPlayers()
        {
            players.Add(new OtherPlayers("Adam"));
            players.Add(new OtherPlayers("Bára"));
            players.Add(new OtherPlayers("Honza"));
            players.Add(new OtherPlayers("Emma"));
        }

        public void GameStarts()
        {
            Console.WriteLine("The game is starting...");
        }

        public int DiceInGame()
        {
            currentDiceNumber = random.Next(1, 7); // generování nového čísla kostky
            return currentDiceNumber;
        }
    }
}

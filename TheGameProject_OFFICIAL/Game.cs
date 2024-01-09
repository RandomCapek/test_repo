using System;
using System.Collections.Generic;

namespace TheGameProject
{
    internal class Game // docela nahodna trida ngl :o
    {
        Random random = new Random();
        public int currentDiceNumber; // ulozi aktualni hod kostkou (hodnotu na kostce)

        public int DiceInGame() // actual hod kostkou
        {
            currentDiceNumber = random.Next(1, 7);
            return currentDiceNumber;
        }
    }
}

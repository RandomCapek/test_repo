using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject_Attempt
{
    internal class Dice
    {
        Random random = new Random();

        public int diceNumber;

        public Dice()
        {
            random = new Random();
        }

        public void DiceNumbers()
        {
            diceNumber = random.Next(1, 7);
        }
    }
}

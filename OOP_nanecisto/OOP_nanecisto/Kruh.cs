using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_nanecisto
{
    using System.Drawing;
    internal class Kruh
    {
        public int x, y;
        public int velikost;
        public Pen pero;

        public void Zvetsit()
        {
            velikost = velikost + 10;
        }
        public void Zmensit()
        {
            velikost = velikost - 10;
        }

    }
    internal class Potomek : Kruh
    {
        public void Doprava()
        {
            x = x + 10;
        }
        public void Doleva()
        {
            x = x - 10;
        }
        public void Nahoru()
        {
            y = y - 10;
        }
        public void Dolu()
        {
            y = y + 10;
        }
    }
}

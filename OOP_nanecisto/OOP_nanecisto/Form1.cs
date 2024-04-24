using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_nanecisto
{
    public partial class Form1 : Form
    {
        Kruh kol1 = new Kruh();
        Potomek kol2 = new Potomek();
        Potomek kol3 = new Potomek();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kol1.x = 20;
            kol1.y = 20;
            kol1.pero = Pens.Red;
            kol1.velikost = 150;
            kol2.x = 200;
            kol2.y = 20;
            kol2.pero = Pens.Blue;
            kol2.velikost = 100;
            kol3.x = 20;
            kol3.y = 200;
            kol3.pero = Pens.Green;
            kol3.velikost = 100;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(kol1.pero,kol1.x,kol1.y,kol1.velikost, kol1.velikost);
            g.DrawEllipse(kol2.pero, kol2.x, kol2.y, kol2.velikost, kol2.velikost);
            g.DrawEllipse(kol3.pero, kol3.x, kol3.y, kol3.velikost, kol3.velikost);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)
            {
                kol1.Zvetsit();
                kol2.Zvetsit();
                kol3.Zvetsit();
            }
            if (e.KeyCode == Keys.M)
            {
                kol1.Zmensit();
                kol2.Zmensit();
                kol3.Zmensit();
            }
            if (e.KeyCode == Keys.Right)
            {
                kol2.Doprava();
                kol3.Doprava();
            }
            if (e.KeyCode == Keys.Left)
            {
                kol2.Doleva();
                kol3.Doleva();
            }
            if (e.KeyCode == Keys.Up)
            {
                kol2.Nahoru();
                kol3.Nahoru();
            }
            if (e.KeyCode == Keys.Down)
            {
                kol2.Dolu();
                kol3.Dolu();
            }
            Refresh();
        }

        
    }
}

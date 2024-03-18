using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDrawingShit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 870;       // nadefinuji velikost otevřené aplikace (konzole)
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }

        Bitmap bm;
        Graphics g;
        bool paint = false; //defaultne je paint na false (na true je az kdyz uzivatel stiskne mys na platne)
        Point px, py;
        Pen p = new Pen(Color.Black,1);
        Pen erase = new Pen(Color.White, 20); // premaluje na bílo
        int index; // podle indexu poznam, jaky ukol chci (čara, obdélník, tužka, ...)
        int x, y, sX,sY,cX,cY;
        ColorDialog cd = new ColorDialog(); // vytvoreni noveho dialogu barev (cd)
        Color new_color; // vytvoreni promenne new_color

        private void pic_MouseDown(object sender, MouseEventArgs e) // stisk myši
        {
            paint = true; // kreslíme!
            py = e.Location;

            cX = e.X; // ulozi se, na jakych souradnicich jsem zacal
            cY = e.Y;
        }


        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index==1) //tužka
                {
                    px = e.Location;
                    g.DrawLine(p,px,py);
                    py = px;
                }
                if (index == 2) //guma
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X; // prubeh souradnic, kam pohybuji se stisknutou mysi
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }


        private void pic_MouseUp(object sender, MouseEventArgs e) // zvednu myš
        {
            paint = false; // konec kreslení

            sX = x - cX;
            sY = y - cY;

            if (index==3) //elipsa
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index==4) //obdélník
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index==5) //čára
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }


        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }


        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void pic_Paint(object sender, PaintEventArgs e) // pro live aktualizaci toho, co právě kreslím
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e) //smazat
        {
            g.Clear(Color.White); //    vymažu plátno, obarvim na bílo
            pic.Image = bm;
            index = 0;
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // otevre se mi dialog barev
            new_color = cd.Color; // ulozeni vybrane barvy do promenne new_color
            pic_color.BackColor = cd.Color; // nastaví pic_color na právě vybranou barvu (vidím ji)
            p.Color = cd.Color; // nastaveni barvy tuzky podle vyberu z dialogu
        }

    }
}

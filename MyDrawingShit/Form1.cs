using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyDrawingShit
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            this.Width = 870;       // nadefinuji velikost otevřené aplikace (konzole/formuláře)
            this.Height = 900;
            bm = new Bitmap(pic.Width, pic.Height); // vytvoření bitmapy pro kreslení
            g = Graphics.FromImage(bm); // instance třídy Graphics, která bude kreslit na bitmapu bm
            g.Clear(Color.White); // defaultne bíleé plátno
            pic.Image = bm; // nastaveni bitmapy na pic.image
            Bitmap bmp = new Bitmap(bm); // udelam kopii prazdneho platna a ulozim ji do zasobniku (aby fungovalo undo i na prvni caru :)
            undo.Push(bmp); // funkce pro undo
        }
        Bitmap bm; // nadefinovani bitmapy
        Graphics g; // nadefinovani grafiky
        bool paint = false; //defaultne je paint na false (na true je az kdyz uzivatel stiskne mys na platne)
        Point px, py; //souradnice mysi
        Pen p = new Pen(Color.White, 1); //klasická tužka
        Pen erase = new Pen(Color.White, 30); // premaluje na bílo
        int index; // podle indexu poznam, jaky ukol chci (čara, obdélník, tužka, ...)
        int x, y, sX, sY, cX, cY; //nové proměnné souřadnic
        ColorDialog cd = new ColorDialog(); // vytvoreni noveho dialogu barev (cd)
        Color new_color; // vytvoreni promenne new_color

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) //scroll bra na tloušťku čáry
        {
            ChangePenSize(hScrollBar1.Value); // změní tloušťku pera a gumy podle hodnoty na scrollbaru :)
        }
        private void ChangePenColor(Color new_color) // funkce pro změnu barvy
        {
            this.new_color = new_color;
            pic_color.BackColor = new_color; // abych videl co mam prave za barvu
            p.Color = new_color; // nova barva peru
        }
        private void ChangePenSize(float new_width) // funkce pro změnu velikosti pera
        {
            p.Width = new_width; // nova tloustka peru
            erase.Width = new_width; //nova tloustka gumy
        }
        private void pic_MouseDown(object sender, MouseEventArgs e) // stisk myši
        {
            paint = true; // kreslíme!
            py = e.Location;

            cX = e.X; // ulozi se, na jakych souradnicich jsem zacal (klikl)
            cY = e.Y;
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1) //tužka
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    //pro tlustší čáry
                    float r = p.Width;
                    float rX = px.X - r / 2;
                    float rY = px.Y - r / 2;
                    g.FillEllipse(new SolidBrush(new_color), rX, rY, r, r);
                    py = px;
                }
                if (index == 2) //guma
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    //aby guma fungovala stejne jako tlustsi cary
                    float r2 = erase.Width;
                    float rX = px.X - r2 / 2;
                    float rY = px.Y - r2 / 2;
                    g.FillEllipse(new SolidBrush(Color.White), rX, rY, r2, r2);
                    py = px;
                }
            }
            x = e.X; // prubeh souradnic, kam pohybuji se stisknutou mysi
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
            pic.Refresh();
        }
        private void pic_MouseUp(object sender, MouseEventArgs e) // zvednu myš
        {
            paint = false; // konec kreslení

            sX = x - cX;
            sY = y - cY;

            if (index == 3) //elipsa
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4) //obdélník
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5) //čára
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            Bitmap bmp = new Bitmap(bm); // delam kopii aktualniho stavu platna
            undo.Push(bmp); // ulozim kopii do "zasobniku"
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
        private void btn_clear_Click(object sender, EventArgs e) //smazat
        {
            g.Clear(Color.White); // vymažu plátno, obarvim na bílo
            pic.Image = bm;
            index = 0;
        }
        private void btn_color_Click(object sender, EventArgs e) //dialog barev
        {
            cd.ShowDialog(); // otevre se mi dialog barev
            new_color = cd.Color; // ulozeni vybrane barvy do promenne new_color
            pic_color.BackColor = cd.Color; // nastaví pic_color na právě vybranou barvu (vidím ji)
            p.Color = cd.Color; // nastaveni barvy tuzky podle vyberu z dialogu
        }

        private Stack<Bitmap> undo = new Stack<Bitmap>(); // "zasobnik" pro ukladani stavu platna (funkce undo)

        // snazil jsem se i o udelani tlacitka "redo" neboli znovu neboli proste aby to slo vratit zpatky to undo
        // jako jsou klasicky sipka tam a zpatky
        //ale neslo mi to s tema zasobnikama :(

        private void btn_undo_Click(object sender, EventArgs e) //undo
        {
            if (undo.Count > 0)
            {
                bm = undo.Pop(); // vratim posledni stav platna ze "zasobniku"
                g = Graphics.FromImage(bm); // vytvorim novy graphics pro novy stav platna
                pic.Image = bm; // nastavim novy stav platna
            }
        }
        private void btn_insert_Click(object sender, EventArgs e) // vložit
        {   //zkopiroval jsem to z chatuGPT
            //moc netusim, co to dela
            //ale lip bych to sam neudelal, takze to takhle necham ups :D
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Načtení vybraného obrázku
                        Image loadedImage = Image.FromFile(openFileDialog.FileName);
                        // Zobrazení obrázku v PictureBoxu
                        pic.Image = loadedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        //tlačítka "quick" barev
        private void color_black_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Black);
        }
        private void color_red_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Red);
        }
        private void color_blue_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Blue);
        }
        private void color_green_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Lime);
        }
        private void color_yellow_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Yellow);
        }
        private void color_orange_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.DarkOrange);
        }
        private void color_pink_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.Fuchsia);
        }
        private void color_white_Click(object sender, EventArgs e)
        {
            ChangePenColor(Color.White);
        }
    }
}

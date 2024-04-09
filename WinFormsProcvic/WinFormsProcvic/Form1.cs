using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsProcvic
{
    public partial class Form1 : Form
    {
        Rectangle rectInstance;
        bool isLeftMouseDown = false;
        bool isRightMouseDown = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //if (rectInstance.filled)
            //{
            //    e.Graphics.FillRectangle(
            //        rectInstance.brush,
            //        rectInstance.x,
            //        rectInstance.y,
            //        rectInstance.width,
            //        rectInstance.height
            //        );
            //}
            //else
            //{
            //    e.Graphics.DrawRectangle(
            //        rectInstance.pen,
            //        rectInstance.x,
            //        rectInstance.y,
            //        rectInstance.width,
            //        rectInstance.height
            //        );
            //}
            rectInstance.DrawRectangle(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rectInstance = new Rectangle(100, 100, 100, 100, false, Brushes.Black, Pens.Green);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isRightMouseDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isRightMouseDown = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftMouseDown)
            {
                rectInstance.x = e.X;
                rectInstance.y = e.Y;
                Refresh();
            }
            else if (isRightMouseDown)
            {
                rectInstance.width = Math.Abs(e.X - rectInstance.x);
                rectInstance.height = Math.Abs(e.Y - rectInstance.y);
                Refresh();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'f')
            {
                rectInstance.filled = !rectInstance.filled;
                Refresh();
            }
        }
    }
}

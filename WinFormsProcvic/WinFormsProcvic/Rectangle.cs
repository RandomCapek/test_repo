using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProcvic
{
    internal class Rectangle
    {
        public int x, y, width, height;
        public bool filled;
        public Brush brush;
        public Pen pen;

        public Rectangle(int x, int y, int width, int height, bool filled, Brush brush, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.filled = filled;
            this.brush = brush;
            this.pen = pen;
        }
        public void DrawRectangle (Graphics g)
        {
            if (filled)
            {
                g.FillRectangle(
                    brush,
                    x,
                    y,
                    width,
                    height
                    );
            }
            else
            {
                g.DrawRectangle(
                    pen,
                    x,
                    y,
                    width,
                    height
                    );
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace CSharpLabWork
{
    internal class GraphObject
    {
        static Random r = new Random();

        Color color;
        int PointX { get; init; }
        int PointY { get; init; }
        int Width { get; init; }
        int Height { get; init; }
        Pen Pen { get; set; } = Pens.Green;

        public void ChangePenColor(MouseEventArgs e)
        {
            if (e.X > PointX && e.Y > PointY && e.X < PointX + Width && e.Y < PointY + Height) 
            {
                Pen = Pens.Blue;
            }
        }

        SolidBrush brush;
        public GraphObject(int maxPointX, int maxPointY, int pointX = 0, int pointY = 0)
        {
            color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            if (PointX < 0 || PointY < 0)  { throw new ArgumentException("point < 0 !"); }
            Width = r.Next(10, maxPointX / 2);
            Height = r.Next(10, maxPointY / 2);
            if (pointX == 0 && pointY == 0)
            {
                PointX = r.Next(maxPointX - Width);
                PointY = r.Next(maxPointY - Height);
            }
            else
            {
                PointX = pointX;
                PointY = pointY;
            }
            brush = new SolidBrush(color);
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, PointX, PointY, Width, Height);
            g.DrawRectangle(Pen, PointX, PointY, Width, Height);
        }

    }
}

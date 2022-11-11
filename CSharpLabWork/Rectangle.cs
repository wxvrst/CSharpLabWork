using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal class Rectangle : GraphObject
    {
        static Random r = new Random();
        public int Width { get; init; }
        public int Height { get; init; }
        public Rectangle(int maxPointX, int maxPointY, int pointX = 0, int pointY = 0)
            : base(pointX, pointY)
        {
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
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, PointX, PointY, Width, Height);
            g.DrawRectangle(FigurePen, PointX, PointY, Width, Height);
        }
        public override bool ContainsPoint(MouseEventArgs e)
        {
            return e.X > PointX && e.Y > PointY && e.X < PointX + Width && e.Y < PointY + Height;
        }
    }
}

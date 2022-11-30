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
        public Rectangle(int pointX = 0, int pointY = 0)
            : base(pointX, pointY)
        {

        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, PointX, PointY, Width, Height);
            if (Selected)
            {
                g.DrawRectangle(Pens.Blue, PointX, PointY, Width, Height);
            }
            else
            {
                g.DrawRectangle(Pens.Transparent, PointX, PointY, Width, Height);
            }
        }
        public override bool ContainsPoint(MouseEventArgs e)
        {
            return e.X > PointX && e.Y > PointY && e.X < PointX + Width && e.Y < PointY + Height;
        }
    }
}

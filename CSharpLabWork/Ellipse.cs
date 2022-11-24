using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal class Ellipse : GraphObject
    {
        static Random r = new Random();
        public Ellipse(int maxPointX, int maxPointY, int pointX = 0, int pointY = 0)
            : base(maxPointX, maxPointY, pointX, pointY)
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, PointX, PointY, Width, Height);
            g.DrawEllipse(FigurePen, PointX, PointY, Width, Height);
        }
        public override bool ContainsPoint(MouseEventArgs e)
        {

            return Math.Pow((e.X - PointX) / Width, 2) + Math.Pow((e.Y - PointY) / Height, 2) <= 1;
        }
    }
}

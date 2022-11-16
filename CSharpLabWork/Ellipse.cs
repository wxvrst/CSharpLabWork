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
        public int AAxis { get; init; }
        public int BAxis { get; init; }
        public Ellipse(int maxPointX, int maxPointY, int pointX = 0, int pointY = 0)
            : base(pointX, pointY)
        {
            AAxis = r.Next(10, maxPointX / 2);
            BAxis = r.Next(10, maxPointY / 2);
            if (pointX == 0 && pointY == 0)
            {
                PointX = r.Next(maxPointX - AAxis);
                PointY = r.Next(maxPointY - BAxis);
            }
            else
            {
                PointX = pointX;
                PointY = pointY;
            }
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, PointX, PointY, AAxis, BAxis);
            g.DrawEllipse(FigurePen, PointX, PointY, AAxis, BAxis);
        }
        public override bool ContainsPoint(MouseEventArgs e)
        {
            //(x-x0)^2/a^2 + (y-y0)^2/b^2 <=1
            return Math.Pow((e.X - PointX) / AAxis, 2) + Math.Pow((e.Y - PointY) / BAxis, 2) <= 1; 
        }
    }
}

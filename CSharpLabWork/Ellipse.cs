using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal class Ellipse : GraphObject
    {
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
            // TODO: change this shit: replace Width, Height with AAxis, BAxis
            return e.X > PointX && e.Y > PointY && e.X < PointX + Width && e.Y < PointY + Height;
        }
    }
}

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
        public Ellipse()
            : base()
        {
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, PointX, PointY, Width, Height);
            if (Selected)
            {
                g.DrawEllipse(Pens.Blue, PointX, PointY, Width, Height);
            }
            else
            {
                g.DrawEllipse(Pens.Transparent, PointX, PointY, Width, Height);
            }
        }
        public override bool ContainsPoint(MouseEventArgs e)
        {
            double cx = PointX + Width / 2;
            double a = Width / 2;
            double cy = PointY + Height / 2;
            double b = Height / 2;
            return (e.X - cx) * (e.X - cx) / (a * a) + (e.Y - cy) * (e.Y - cy) / (b * b) <= 1;
        }
    }
}

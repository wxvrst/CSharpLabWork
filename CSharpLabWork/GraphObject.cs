using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace CSharpLabWork
{
    internal abstract class GraphObject : IFigureBuilding
    {
        static Random r = new Random();

        public Color color;
        public bool Selected { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public Pen FigurePen { get; set; } = new(Brushes.Red, 2);
        public SolidBrush brush;

        public abstract bool ContainsPoint(MouseEventArgs e);
        public abstract void Draw(Graphics g);
        public GraphObject(int pointX = 0, int pointY = 0)
        {
            color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            if (PointX < 0 || PointY < 0)  { throw new ArgumentException("point < 0 !"); }
            brush = new SolidBrush(color);
        }

    }
}

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
        public int PointX { get; init; }
        public int PointY { get; init; }
        public int Width { get; init; }
        public int Height { get; init; }
        public Pen FigurePen { get; set; } = Pens.Green;
        public SolidBrush brush;

        public abstract bool ContainsPoint(MouseEventArgs e);
        public abstract void Draw(Graphics g);
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

    }
}

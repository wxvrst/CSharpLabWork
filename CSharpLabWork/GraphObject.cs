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
        static public Size PanelSize { get; set; }
        public Color color;
        public bool Selected { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int Width { get; init; }
        public int Height { get; init; }
        public SolidBrush brush;

        public abstract bool ContainsPoint(MouseEventArgs e);
        public abstract void Draw(Graphics g);

        public GraphObject(int pointX = 0, int pointY = 0)
        {
            color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            brush = new SolidBrush(color);

            Width = r.Next(PanelSize.Width / 8, PanelSize.Width / 2);
            Height = r.Next(PanelSize.Height / 8, PanelSize.Height / 2);
            if (pointX == 0 && pointY == 0)
            {
                PointX = r.Next(PanelSize.Width - Width);
                PointY = r.Next(PanelSize.Height - Height);
            }
            else
            {
                PointX = pointX;
                PointY = pointY;
            }
        }
    }
}

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
        static Size panelSize;
        Color color;
        bool selected;
        int pointX;
        int pointY;
        int width;
        int height;
        SolidBrush brush;
        public static Size PanelSize { get { return panelSize; } set { panelSize = value; } }
        public Color Color { get { return color; } set { color = value; } }
        public bool Selected { get { return selected; } set { selected = value; } }
        public int PointX { get { return pointX; } set { pointX = value; } }
        public int PointY { get { return pointY; } set { pointY = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }
        public SolidBrush Brush { get { return brush; } set { brush = value; } }

        public abstract bool ContainsPoint(MouseEventArgs e);
        public abstract void Draw(Graphics g);

        public GraphObject()
        {
            color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            color.ToKnownColor();
            brush = new SolidBrush(color);

            Width = r.Next(PanelSize.Width / 8, PanelSize.Width / 2);
            Height = r.Next(PanelSize.Height / 8, PanelSize.Height / 2);
            PointX = r.Next(PanelSize.Width - Width);
            PointY = r.Next(PanelSize.Height - Height);

        }
    }
}

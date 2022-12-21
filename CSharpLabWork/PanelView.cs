using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;

namespace CSharpLabWork
{
    public delegate void NodeClicked(Node node);
    internal class PanelView : Panel, IView
    {
        IModel model;
        public event NodeClicked OnNodeClicked;
        public IModel Model { get { return model; } set { model = value; } }

        public void UpdateView()
        {
            Invalidate();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            foreach (Node node in model.AllNodes)
            {
                if (Math.Pow(e.X - (node.X * 20) % (this.Size.Width - 20) - 10, 2) + Math.Pow(e.Y - (node.Y * 20) % (this.Size.Height - 20) - 10, 2) <= 100 && OnNodeClicked != null)
                {
                    OnNodeClicked(node);
                    return;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (model == null) { return ; }
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(Pens.Red, (n.X * 20) % (this.Size.Width - 20), (n.Y * 20) % (this.Size.Height - 20), 20, 20);
            }
        }
    }
}

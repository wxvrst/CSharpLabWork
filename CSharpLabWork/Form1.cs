using System.Xml.Linq;

namespace CSharpLabWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<GraphObject> elements = new List<GraphObject>();

        private void Exit()
        {
            this.Close();
        }
        private void AddFigure()
        {
            Random r = new Random();
            if (r.Next(2) % 2 == 0)
            {
                elements.Add(new Rectangle(panel1.Size.Width, panel1.Size.Height, 0, 0));
            }
            else
            {
                elements.Add(new Ellipse(panel1.Size.Width, panel1.Size.Height, 0, 0));
            }
            panel1.Invalidate();
        }
        private void AddPointFigure(int pointX = 0, int pointY = 0)
        {
            Random r = new Random();
            if (r.Next(2) % 2 == 0) 
            {
                elements.Add(new Rectangle(panel1.Size.Width, panel1.Size.Height, pointX, pointY));
            }
            else
            {
                elements.Add(new Ellipse(panel1.Size.Width, panel1.Size.Height, pointX, pointY));
            }
            panel1.Invalidate();
        }
        private void ClearFigures()
        {
            elements.RemoveRange(0, elements.Count);
            Refresh();
        }
        private void DeleteFigure()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Selected)
                {
                    elements.RemoveAt(i);
                }
            }
            Refresh();
        }
        private void MoveFigure()
        {
            //function will move selected element around the form
            foreach(GraphObject element in elements)
            {
                Random r = new Random();
                if (element.Selected)
                {
                    element.PointX = r.Next(Math.Abs(panel1.Size.Width - Width));
                    element.PointY = r.Next(Math.Abs(panel1.Size.Height - Height));
                }
                element.Selected = false;
                element.FigurePen.Color = Color.Red;
            }
            panel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFigure();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddFigure();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearFigures();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ClearFigures();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFigure();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteFigure();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddPointFigure(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int k = 0;
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                if (elements[i].ContainsPoint(e)) { k = i; break; }
            }
            if (!elements[k].Selected)//todo: fix error when choosed clear space + if only one rectangle in the panel
            {
                elements[k].FigurePen.Color = Color.Blue;
                elements[k].Selected = true;
            }
            else
            {
                elements[k].FigurePen.Color = Color.Red;
                elements[k].Selected = false;
            }
            panel1.Invalidate();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFigure();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFigures();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteFigure();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveFigure();
        }
    }
}
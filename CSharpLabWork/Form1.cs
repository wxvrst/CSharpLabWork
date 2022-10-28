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
        private void AddFigure(int pointX = 0, int pointY = 0)
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
            panel1.Controls.Clear();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddFigure(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = elements.Count - 1; i >= 0; i--) 
            {
                // TODO: change this shit: only one element can be selected
                if (elements[i].ContainsPoint(e))
                {
                    if (!elements[i].Selected)
                    {
                        elements[i].FigurePen = Pens.Blue;
                        elements[i].Selected = true;
                    }
                    else
                    {
                        elements[i].FigurePen = Pens.Green;
                        elements[i].Selected = false;
                    }
                    break;
                }
            }
            panel1.Invalidate();
        }
    }
}
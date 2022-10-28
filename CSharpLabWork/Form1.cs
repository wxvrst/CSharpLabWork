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
            elements.Add(new GraphObject(panel1.Size.Width, panel1.Size.Height, pointX, pointY));
            panel1.Invalidate();
        }
        private void ClearFigures()
        {
            
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
            for (int i = elements.Count - 1; i > 0; i--) 
            {
                elements[i].ChangePenColor(e);
            }
            panel1.Invalidate();
        }
    }
}
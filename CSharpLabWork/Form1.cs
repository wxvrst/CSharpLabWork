using System.Xml.Linq;
namespace CSharpLabWork
{
    public partial class Form1 : Form
    {
        List<GraphObject> elements = new List<GraphObject>();
        Random random = new Random();
        private IGraphicFactory factory = new RandomObjectFactory();
        private RandomObjectFactory randomFactory = new RandomObjectFactory();
        private TwoTypeFactory twoTypeFactory = new TwoTypeFactory();

        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            GraphObject.PanelSize = panel1.ClientSize;
        }

        private void Exit()
        {
            this.Close();
        }
        private void AddFigure()
        {
            elements.Add(factory.CreateGraphObject());
            panel1.Invalidate();
        }
        private void AddPointFigure(int pointX , int pointY )
        {
            GraphObject pointFigure = factory.CreateGraphObject();
            pointFigure.PointX = pointX;
            pointFigure.PointY = pointY;

            elements.Add(pointFigure);
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
                    elements.RemoveAt(i);//todo: fix situation when delets not all selected figures
                }
            }
            Refresh();
        }
        private void MoveFigure()
        {
            //function will move selected element around the form
            foreach(GraphObject element in elements)
            {
                if (element.Selected)
                {

                    element.PointX = random.Next(panel1.Size.Width - element.Width);
                    element.PointY = random.Next(panel1.Size.Height - element.Height);
                }
                element.Selected = false;
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
            if (elements.Count == 0)
            {
                MessageBox.Show("There is no one figure!");
            }
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = elements.Count - 1; i >= 0; i--)
                    {
                        if (elements[i].ContainsPoint(e))
                        {
                            if (!elements[i].Selected)
                            {
                                elements[i].Selected = true;
                            }
                            else
                            {
                                elements[i].Selected = false;
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                int k = -1;
                for (int i = elements.Count - 1; i >= 0; i--)
                {
                    if (k == -1 && elements[i].ContainsPoint(e))
                    {
                        if (!elements[i].Selected)
                        {
                            elements[i].Selected = true;
                        }
                        else
                        {
                            elements[i].Selected = false;
                        }
                        k = i;
                    }
                    else { elements[i].Selected = false; }
                }

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

        private void moveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoveFigure();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MoveFigure();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                factory = randomFactory;
            }
            else
            {
                factory = twoTypeFactory;
            }
        }
    }
}
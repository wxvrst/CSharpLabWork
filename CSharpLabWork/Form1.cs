using System;
using System.Reflection;

namespace CSharpLabWork
{
    public partial class Form1 : Form, IController
    {
        IModel model;
        static Random random = new Random();
        public IModel Model { get { return model; } set { model = value; } }
        public Form1()
        {
            InitializeComponent();
            Model = new MyModel();
            IView labView = new LabelView(label1);
            labView.Model = Model;
            labView.UpdateView();
            AddView(labView);
            panelView2.Model = Model;
            panelView2.UpdateView();
            panelView2.OnNodeClicked += Model.RemoveNode;
            AddView(panelView2);
        }
        public void Add()
        {
            model.AddNode(random.Next(100));
        }

        public void AddView(IView view)
        {
            model.Changed += new Action(view.UpdateView);
        }

        public void Remove()
        {
            model.RemoveLastNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            myDataGrid1.AutoGenerateColumns = true;
            myDataGrid1.DataSource = Model.AllNodes.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Model.Count > 0)
            {
                Remove();
            }
            else
            {
                MessageBox.Show("Итак ноль");
            }
            myDataGrid1.AutoGenerateColumns = true;
            myDataGrid1.DataSource = Model.AllNodes.ToArray();
        }
    }
}
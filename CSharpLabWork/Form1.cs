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
            AddView(labView);
            panelView2.OnNodeClicked += Model.RemoveNode;
            AddView(panelView2);
            AddView(myDataGrid1);
        }
        public void Add()
        {
            model.AddNode(random.Next(100));
        }

        public void AddView(IView view)
        {
            view.Model = Model;
            model.Changed += new Action(view.UpdateView);
            view.UpdateView();
        }

        public void Remove()
        {
            model.RemoveLastNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Model.Count > 0)
            {
                Remove();
            }
            else
            {
                MessageBox.Show("It's already zero");
            }
        }
    }
}

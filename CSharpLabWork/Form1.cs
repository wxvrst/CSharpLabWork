namespace CSharpLabWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<IView> views = new List<IView>();
        List<IModel> models = new List<IModel>();
    }
}
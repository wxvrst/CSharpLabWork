using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    public class MyDataGrid : DataGridView, IView
    {
        IModel model;
        public IModel Model { get { return model; } set { model = value; } }

        public void UpdateView()
        {
            AutoGenerateColumns = true;
            DataSource = Model.AllNodes.ToArray();
        }
    }
}

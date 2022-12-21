using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    public class LabelView : IView
    {
        Label label;
        IModel model;
        public IModel Model { get { return model; } set { model = value; } }
        public LabelView(Label lab)
        {
            label = lab;
        }

        public void UpdateView() => label.Text = model.Count.ToString();
    }
}

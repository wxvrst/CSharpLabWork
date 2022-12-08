using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal interface IController
    {
        IModel Model { get; set; }
        void AddView(IView v);
        void Add();
        void Remove();
    }
}

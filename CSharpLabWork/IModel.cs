using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    public interface IModel
    {
        IEnumerable<Node> AllNodes { get;}
        void AddNode(int value);
        void RemoveNode(Node node);
        void RemoveLastNode();
        int Count { get; }

        event Action Changed;
    }
}

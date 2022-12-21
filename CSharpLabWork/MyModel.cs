using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    public class MyModel : IModel
    {
        LinkedList<Node> nodes=new LinkedList<Node>();
        static Random random = new Random();
        Action changed = null;
        public event Action Changed
        {
            add { changed += value; }
            remove { changed -= value; }
        }
        public void InvokeEvent()
        {
            if (changed != null)
            {
                changed.Invoke();
            }
        }
        public int Count => nodes.Count;

        public IEnumerable<Node> AllNodes => nodes;

        public void AddNode(int value) 
        {
            nodes.AddFirst(new Node(value, random.Next(40), random.Next(40)));
            InvokeEvent();
        }
        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            InvokeEvent();
        }

        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            InvokeEvent();
        }

    }
}

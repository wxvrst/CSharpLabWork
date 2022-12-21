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

        public event Action Changed;

        public int Count => nodes.Count;

        public IEnumerable<Node> AllNodes => nodes;

        public void AddNode(int value) 
        {
            nodes.AddFirst(new Node(value, random.Next(40), random.Next(40)));
            if (Changed != null)
                Changed();
        }
        public void RemoveLastNode()
        {
            nodes.RemoveLast();
            if (Changed != null)
                Changed();
        }

        public void RemoveNode(Node node)
        {
            nodes.Remove(node);
            if (Changed != null)
            {
                Changed();
            }
        }

        }
    }

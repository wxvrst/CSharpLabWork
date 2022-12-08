using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal class MyModel : IModel
    {
        LinkedList<Node> nodes=new LinkedList<Node>();
        static Random random = new Random();

        public int Count { get { return nodes.Count; } set { Count = value; } }

        public void AddNode(int value)
        {
            nodes.AddFirst(new Node(value, random.Next(10), random.Next(10)));
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
        }
    }
}

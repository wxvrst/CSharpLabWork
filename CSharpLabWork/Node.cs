using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    public class Node
    {
        int value;
        int x;
        int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Value { get { return value; } set { x = value; } }
        public Node(int value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }

    }
}

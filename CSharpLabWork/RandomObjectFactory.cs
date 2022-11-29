using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpLabWork
{
    internal class RandomObjectFactory
    {
        public GraphObject CreateGraphObject()
        {
            Random r = new Random();
            if (r.Next(2) % 2 == 0)
            {
                return new Rectangle();
            }
            else
            {
                return new Ellipse();
            }
        }
    }
}

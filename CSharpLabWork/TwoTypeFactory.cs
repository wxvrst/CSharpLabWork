using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal class TwoTypeFactory : IGraphicFactory
    {
        static int k = 0;
        public GraphObject CreateGraphObject()
        {
            if (k == 0)
            {
                k = 1;
                return new Rectangle();
            }
            else
            {
                k = 0;
                return new Ellipse();
            }

        }
    }
}

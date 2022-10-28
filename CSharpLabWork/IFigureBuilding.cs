using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabWork
{
    internal interface IFigureBuilding
    {
        bool ContainsPoint(MouseEventArgs e);
        void Draw(Graphics g);
    }
}

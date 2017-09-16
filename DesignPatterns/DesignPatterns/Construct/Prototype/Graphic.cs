using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Prototype
{
    public interface Graphic // prototype
    {
        void Draw(int posX, int posY);
        Graphic Clone();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Some class implementing shape interface
    /// </summary>
    public class Line : Shape
    {
        public void BoundingBox()
        {
            throw new NotImplementedException();
        }

        public void CreateManipulator()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Adaptee
    /// Already existing api
    /// </summary>
    public class TextView
    {
        internal void OtherApiBoundingBox()
        {
            throw new NotImplementedException();
        }

        internal void OtherApiCreateManipulator()
        {
            throw new NotImplementedException();
        }
    }
}

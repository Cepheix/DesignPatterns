using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class DrawingEditor
    {
        public void Run()
        {
            TextView adaptee = new TextView();
            Shape target = new TextShape(adaptee);
            target.BoundingBox();
            target.CreateManipulator();
        }
    }
}

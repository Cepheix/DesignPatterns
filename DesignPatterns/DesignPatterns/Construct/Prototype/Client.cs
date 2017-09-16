using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Prototype
{
    public class Client
    {
        public void Run()
        {
            Graphic note = new HalfNote();
            Tool manipulator = new GraphicTool(note);
            manipulator.Manipulate();
        }
    }
}

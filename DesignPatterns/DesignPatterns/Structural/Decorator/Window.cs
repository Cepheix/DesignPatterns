using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Window
    {
        public void DrawWindow()
        {
            VisualComponent textView = new TextView();

            Decorator scroll = new ScrollDecorator(textView, 0); // add scroll

            Decorator border = new BorderDecorator(scroll, 10); // add border

            border.Draw(); // draw everything
        }
    }
}

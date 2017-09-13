using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.AbstractFactory
{
    public class DarkThemeWidgetFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new DarkScrollBar();
        }

        public override TextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
}

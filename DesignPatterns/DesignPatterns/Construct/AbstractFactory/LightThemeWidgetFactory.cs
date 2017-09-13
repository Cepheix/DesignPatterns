using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.AbstractFactory
{
    public class LightThemeWidgetFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new LightScrollBar();
        }

        public override TextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}

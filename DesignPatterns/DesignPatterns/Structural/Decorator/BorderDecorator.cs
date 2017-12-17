using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(VisualComponent component) : base(component)
        {
        }

        public BorderDecorator(VisualComponent component, int borderWidth) : this(component)
        {
            this.BorderWidth = borderWidth;
        }

        private void DrawBorder(int border)
        {
            throw new NotImplementedException();
        }

        public override void Decorate()
        {
            this.DrawBorder(this.BorderWidth);
        }

        public int BorderWidth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(VisualComponent component) : base(component)
        {
        }

        public ScrollDecorator(VisualComponent component, int scrollPosition) : this(component)
        {
            this.ScrollPosition = scrollPosition;
        }

        public override void Decorate()
        {
            ScrollTo(ScrollPosition);
        }

        private void ScrollTo(int scrollPosition)
        {

        }

        public int ScrollPosition { get; set; }
    }
}

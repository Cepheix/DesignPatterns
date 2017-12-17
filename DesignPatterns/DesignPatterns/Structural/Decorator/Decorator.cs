using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Decorator : VisualComponent
    {
        private readonly VisualComponent _component;

        public Decorator(VisualComponent component)
        {
            this._component = component;
        }

        public void Draw()
        {
            this._component.Draw();
            Decorate();
        }

        public abstract void Decorate();
    }
}

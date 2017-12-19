using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    public abstract class Widget : HelpHandler
    {
        protected Widget(HandlerBase handler) : base(handler)
        {
        }

        public abstract void Draw();
    }
}

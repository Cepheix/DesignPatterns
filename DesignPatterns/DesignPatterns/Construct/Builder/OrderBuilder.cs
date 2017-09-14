using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public abstract class OrderBuilder
    {
        public abstract void OrderStarter();
        public abstract void OrderMain();
        public abstract void OrderDrink();
    }
}

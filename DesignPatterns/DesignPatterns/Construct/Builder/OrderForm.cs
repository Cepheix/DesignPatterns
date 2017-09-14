using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public class OrderForm
    {
        private readonly OrderBuilder _builder;

        public OrderForm(OrderBuilder builder)
        {
            this._builder = builder;
        }

        public void MakeOrder()
        {
            this._builder.OrderStarter();
            this._builder.OrderMain();
            this._builder.OrderStarter();
        }
    }
}

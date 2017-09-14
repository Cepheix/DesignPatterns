using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public class Client
    {
        public Client()
        {
            OrderBuilder builder = new OnlineOrderBuilder();

            OrderForm form = new OrderForm(builder);

            form.MakeOrder();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    class PhoneOrderBuilder : OrderBuilder
    {
        public override void OrderDrink()
        {
            throw new NotImplementedException();
        }

        public override void OrderMain()
        {
            throw new NotImplementedException();
        }

        public override void OrderStarter()
        {
            throw new NotImplementedException();
        }
    }
}

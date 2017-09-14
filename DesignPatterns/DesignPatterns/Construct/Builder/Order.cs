using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public class Order
    {
        public Starter StarterOrder { get; set; }
        public Main MainOrder { get; set; }
        public Drink DrinkOrder { get; set; }
    }
}

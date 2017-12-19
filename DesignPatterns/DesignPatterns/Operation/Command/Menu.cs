using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.Command
{
    public class Menu
    {
        private List<MenuItem> _menuItems;

        public Menu()
        {
            this._menuItems = new List<MenuItem>();
        }

        public void Add(MenuItem item)
        {
            this._menuItems.Add(item);
        }
    }
}

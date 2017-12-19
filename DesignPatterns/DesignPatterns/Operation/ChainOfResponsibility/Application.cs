using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    public class Application
    {
        public void Run()
        {
            Tooltip tooltip = new Tooltip();

            Dialog dialog = new Dialog(tooltip);

            Button button = new Button(dialog);
        }
    }
}

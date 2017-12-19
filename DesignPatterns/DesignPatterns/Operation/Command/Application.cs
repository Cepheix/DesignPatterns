using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.Command
{
    /// <summary>
    /// creates the command and invoker
    /// </summary>
    public class Application
    {
        private Document _document;

        public void Run()
        {
            Menu menu = new Menu();

            Command openCommand = new OpenCommand(this);
            Command pasteCommand = new PasteCommand(this._document);

            MenuItem openMenuItem = new MenuItem(openCommand);
            MenuItem pasteMenuItem = new MenuItem(pasteCommand);

            menu.Add(openMenuItem);
            menu.Add(pasteMenuItem);
        }

        public void Add(Document document)
        {
            this._document = document;
        }
    }
}

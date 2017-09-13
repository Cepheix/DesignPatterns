using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.AbstractFactory
{
    public class Client
    {
        private readonly WidgetFactory _widgetFactory;

        public Client(ClientType type)
        {
            switch (type)
            {
                case ClientType.Dark:
                    this._widgetFactory = new DarkThemeWidgetFactory();
                    break;
                case ClientType.Light:
                    this._widgetFactory = new LightThemeWidgetFactory();
                    break;
            }
        }

        public void MakeWindow()
        {
            ScrollBar scrollbar = this._widgetFactory.CreateScrollBar();
            TextBox textBox = this._widgetFactory.CreateTextBox();

            // draw window with scrollbar and textbox
        }
    }

    public enum ClientType
    {
        Light,
        Dark
    }
}

using System;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    public class Tooltip : HandlerBase
    {
        public override void HandleHelp()
        {
            Console.WriteLine("print help");
        }
    }
}

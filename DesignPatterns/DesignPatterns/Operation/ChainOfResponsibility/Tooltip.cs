using System;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    /// <summary>
    /// concrete handler
    /// </summary>
    public class Tooltip : HandlerBase
    {
        public override void HandleHelp()
        {
            Console.WriteLine("print help");
        }
    }
}

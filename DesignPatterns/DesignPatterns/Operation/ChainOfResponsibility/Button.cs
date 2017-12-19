using System;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    /// <summary>
    /// concrete handler
    /// </summary>
    public class Button : Widget
    {
        public Button(HandlerBase handler) : base(handler)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("button");
        }
    }
}

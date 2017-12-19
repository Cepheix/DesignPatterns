namespace DesignPatterns.Operation.ChainOfResponsibility
{
    public abstract class HelpHandler : HandlerBase
    {
        private readonly HandlerBase _handler;

        protected HelpHandler(HandlerBase handler)
        {
            this._handler = handler;
        }

        public override void HandleHelp()
        {
            this._handler.HandleHelp();
        }
    }
}

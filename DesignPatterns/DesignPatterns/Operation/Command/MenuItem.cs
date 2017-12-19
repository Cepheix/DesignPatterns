namespace DesignPatterns.Operation.Command
{
    /// <summary>
    /// Invoker - invokes the command
    /// </summary>
    public class MenuItem
    {
        private Command _command;

        public MenuItem(Command command)
        {
            this._command = command;
        }

        public virtual void Clicked()
        {
            this._command.Execute();
        }
    }
}

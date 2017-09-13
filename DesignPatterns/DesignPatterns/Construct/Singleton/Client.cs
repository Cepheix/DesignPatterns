namespace DesignPatterns.Construct.Singleton
{
    public class Client
    {
        private readonly Logger _logger = Logger.Instance;

        public void DoSomething()
        {
            this._logger.Log("message");
        }
    }
}

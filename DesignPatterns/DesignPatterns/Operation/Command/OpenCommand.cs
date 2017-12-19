using System;

namespace DesignPatterns.Operation.Command
{
    /// <summary>
    /// concrete command
    /// </summary>
    public class OpenCommand : Command
    {
        private Application _application;

        public OpenCommand(Application application)
        {
            this._application = application;
        }

        public override void Execute()
        {
            string name = AskUser();

            Document document = new Document(name);

            _application.Add(document);

            document.Open();
        }

        private string AskUser()
        {
            throw new NotImplementedException();
        }
    }
}

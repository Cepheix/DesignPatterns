using System;

namespace DesignPatterns.Operation.Command
{
    public class Document
    {
        private string name;

        public Document(string name)
        {
            this.name = name;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Paste()
        {
            throw new NotImplementedException();
        }
    }
}

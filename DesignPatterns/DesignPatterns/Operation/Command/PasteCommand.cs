using System;

namespace DesignPatterns.Operation.Command
{
    /// <summary>
    /// concrete command
    /// </summary>
    public class PasteCommand : Command
    {
        private Document _document;

        public PasteCommand(Document document)
        {
            this._document = document;
        }

        public override void Execute()
        {
            this._document.Paste();
        }
    }
}

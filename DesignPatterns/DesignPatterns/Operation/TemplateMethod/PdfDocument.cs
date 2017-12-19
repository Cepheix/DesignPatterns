using System;

namespace DesignPatterns.Operation.TemplateMethod
{
    /// <summary>
    /// concrete class
    /// </summary>
    public class PdfDocument : Document
    {
        public override string GetText()
        {
            throw new NotImplementedException();
        }

        public override void Open(string name)
        {
            throw new NotImplementedException();
        }
    }
}

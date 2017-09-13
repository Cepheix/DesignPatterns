using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.FactoryMethod
{
    public class Client
    {
        private readonly Document _document;

        public Client()
        {
            DocumentFactory factory = new StandardDocumentFactory();

            this._document = factory.CreateDocument(DocumentType.Word);
        }

        public void PresentDocument()
        {
            // do something with document here
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.FactoryMethod
{
    public class StandardDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument(DocumentType documentType)
        {
            switch (documentType)
            {
                case DocumentType.Pdf:
                    return new PdfDocument();
                case DocumentType.Word:
                    return new WordDocument();
                default:
                    throw new Exception();
            }
        }
    }
}

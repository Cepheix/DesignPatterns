using System;

namespace DesignPatterns.Operation.TemplateMethod
{
    public class Application
    {
        public void Run()
        {
            Document document = new PdfDocument();
            Console.WriteLine(document.Read("book.pdf"));
        }
    }
}

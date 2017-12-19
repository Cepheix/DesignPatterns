namespace DesignPatterns.Operation.TemplateMethod
{
    /// <summary>
    /// abstract class
    /// </summary>
    public abstract class Document
    {
        public abstract void Open(string name);
        public abstract string GetText();

        /// <summary>
        /// Template Method
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Read(string name)
        {
            Open(name);
            return GetText();
        }
    }
}

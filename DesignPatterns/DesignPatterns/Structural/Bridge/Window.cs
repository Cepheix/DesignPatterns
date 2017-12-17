namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Bridge - distinguish class from its inner implementation
    /// </summary>
    public class Window
    {
        private readonly WindowImplementation _windowImplementation;

        public Window(WindowImplementation windowImplementation)
        {
            this._windowImplementation = windowImplementation;
        }

        public void DrawText()
        {
            this._windowImplementation.InnerDrawText();
        }

        public void DrawRect()
        {
            this._windowImplementation.InnerDrawLine();
            this._windowImplementation.InnerDrawLine();
            this._windowImplementation.InnerDrawLine();
            this._windowImplementation.InnerDrawLine();
        }
    }
}

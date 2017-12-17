namespace DesignPatterns.Structural.Bridge
{
    public class TransientWindow : Window
    {
        public TransientWindow(WindowImplementation windowImplementation) : base(windowImplementation)
        {
        }

        public void DrawCloseBox()
        {
            this.DrawRect();
        }
    }
}

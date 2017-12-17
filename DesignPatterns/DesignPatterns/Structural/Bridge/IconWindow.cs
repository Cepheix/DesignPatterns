namespace DesignPatterns.Structural.Bridge
{
    public class IconWindow : Window
    {
        public IconWindow(WindowImplementation windowImplementation) : base(windowImplementation)
        {
        }

        public void DawBorder()
        {
            this.DrawText();
            this.DrawRect();
        }
    }
}

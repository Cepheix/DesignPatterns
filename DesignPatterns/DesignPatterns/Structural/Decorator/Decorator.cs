namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// The base decorator class
    /// </summary>
    public abstract class Decorator : VisualComponent
    {
        private readonly VisualComponent _component;

        protected Decorator(VisualComponent component)
        {
            this._component = component;
        }

        public void Draw()
        {
            this._component.Draw();
            Decorate();
        }

        public abstract void Decorate();
    }
}

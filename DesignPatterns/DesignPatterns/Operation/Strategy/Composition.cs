namespace DesignPatterns.Operation.Strategy
{
    public class Composition
    {
        private Compositor _compositor;

        public Composition(Compositor compositor)
        {
            this._compositor = compositor;
        }

        public void Repair()
        {
            this._compositor.Compose();
        }
    }
}

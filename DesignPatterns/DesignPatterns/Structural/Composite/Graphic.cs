namespace DesignPatterns.Structural.Composite
{
    public abstract class Graphic
    {
        public abstract void Draw();
        public virtual void Add(Graphic g) { }
        public virtual void Remove(Graphic g) { }
        public virtual Graphic GetChild(int position) { return new NullGraphic(); }
    }
}

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight
    /// </summary>
    public abstract class Glyph
    {
        public abstract void Draw(Context context);
        public abstract void Intersect(Point point, Context context);
    }
}

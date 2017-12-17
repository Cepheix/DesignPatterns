namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Concrete flyweight
    /// </summary>
    public class Character : Glyph
    {
        private char _character;

        public Character(char character)
        {
            this._character = character;
        }

        public override void Draw(Context context)
        {
            // draw character
        }

        public override void Intersect(Point point, Context context)
        {
            // intersect
        }
    }
}

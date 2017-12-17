using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Unshared concrete flyweight
    /// </summary>
    public class Row : Glyph
    {
        private List<Glyph> _characters;

        public Row()
        {
            this._characters = new List<Glyph>()
            {
                new Character('a'),
                new Character('b')
            };
        }

        public override void Draw(Context context)
        {
            foreach (Glyph character in this._characters)
            {
                character.Draw(context);
            }
        }

        public override void Intersect(Point point, Context context)
        {
            foreach (Glyph character in this._characters)
            {
                character.Intersect(point, context);
            }
        }
    }
}

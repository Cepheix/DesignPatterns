using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Column : Glyph
    {
        public override void Draw(Context context)
        {
            throw new NotImplementedException();
        }

        public override void Intersect(Point point, Context context)
        {
            throw new NotImplementedException();
        }
    }
}

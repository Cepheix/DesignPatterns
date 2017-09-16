using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Prototype
{
    public class HalfNote : MusicalNote
    {
        public Graphic Clone()
        {
            return new HalfNote();
        }

        public void Draw(int posX, int posY)
        {
            throw new NotImplementedException();
        }
    }
}

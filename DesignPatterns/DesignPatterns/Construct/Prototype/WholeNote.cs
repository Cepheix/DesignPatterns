using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Prototype
{
    public class WholeNote : MusicalNote
    {
        public Graphic Clone()
        {
            return new WholeNote();
        }

        public void Draw(int posX, int posY)
        {
            throw new NotImplementedException();
        }
    }
}

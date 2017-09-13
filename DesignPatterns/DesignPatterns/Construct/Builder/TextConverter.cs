using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public abstract class TextConverter // builder
    {
        public abstract void ConvertCharacter();
        public abstract void ConvertFont();
        public abstract void ConvertParagraph();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Builder
{
    public class RTFReader // director class
    {
        private readonly TextConverter _textConverter;

        public RTFReader(TextConverter converter)
        {
            this._textConverter = converter;
        }

        public void ParseRTF()
        {

        }
    }
}

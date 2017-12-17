using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Scanner
    {
        private readonly InputStream _inputStream;

        public Scanner(InputStream input)
        {
            this._inputStream = input;
        }

        public virtual Token Scan()
        {
            return new Token();
        }
    }
}

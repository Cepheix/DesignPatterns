using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.FactoryMethod
{
    public abstract class Document
    {
        public abstract void Open();
        public abstract void Save();
        public abstract void Close();
    }
}

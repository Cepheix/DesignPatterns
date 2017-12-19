using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Operation.ChainOfResponsibility
{
    /// <summary>
    /// Handler interface
    /// </summary>
    public abstract class HandlerBase
    {
        public abstract void HandleHelp();
    }
}

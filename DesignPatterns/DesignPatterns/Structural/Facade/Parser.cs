using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Parser
    {
        public virtual void Parse(Scanner scanner, ProgramNodeBuilder builder)
        {
        }
    }
}

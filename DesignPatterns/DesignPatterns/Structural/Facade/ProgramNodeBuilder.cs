using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class ProgramNodeBuilder
    {
        private readonly ProgramNode _node;

        public ProgramNodeBuilder()
        {
        }

        public virtual ProgramNode NewAssignment(ProgramNode value, ProgramNode expression)
        {
            // do assignment here
            return this._node;
        }

        public virtual ProgramNode NewReturnStatement(ProgramNode value)
        {
            // do here
            return this._node;
        }

        public virtual ProgramNode NewCondition(ProgramNode condition, ProgramNode truePart, ProgramNode falsePart)
        {
            // do calculation
            return this._node;
        }
    }
}

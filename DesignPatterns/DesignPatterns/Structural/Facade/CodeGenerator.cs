using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Visitor example
    /// </summary>
    public abstract class CodeGenerator
    {
        protected abstract void Visit(StatementNode statementNode);
        protected abstract void Visit(ExpressionNode expressionNode);
    }
}

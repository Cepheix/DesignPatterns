using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class StackMachineCodeGenerator : CodeGenerator
    {
        protected override void Visit(StatementNode statementNode)
        {
            throw new NotImplementedException();
        }

        protected override void Visit(ExpressionNode expressionNode)
        {
            throw new NotImplementedException();
        }
    }
}

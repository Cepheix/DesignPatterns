using System;

namespace DesignPatterns.Operation.Interpreter
{
    /// <summary>
    /// Literal expression
    /// </summary>
    public class LiteralExpression : RegularExpression
    {
        public LiteralExpression(string expression)
        {
        }

        public override void Interpret()
        {
            throw new NotImplementedException();
        }
    }
}

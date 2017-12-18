using System;

namespace DesignPatterns.Operation.Interpreter
{
    /// <summary>
    /// Non terminal expression
    /// </summary>
    public class SequenceExpression : RegularExpression
    {
        private readonly RegularExpression _expression1;
        private readonly RegularExpression _expression2;

        public SequenceExpression(RegularExpression expression1, RegularExpression expression2)
        {
            this._expression1 = expression1;
            this._expression2 = expression2;
        }

        public override void Interpret()
        {
            throw new NotImplementedException();
        }
    }
}

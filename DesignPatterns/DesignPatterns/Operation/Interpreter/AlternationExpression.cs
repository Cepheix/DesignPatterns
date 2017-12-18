using System;

namespace DesignPatterns.Operation.Interpreter
{
    /// <summary>
    /// Non terminal expression
    /// </summary>
    public class AlternationExpression : RegularExpression
    {
        private readonly RegularExpression _alternative1;
        private readonly RegularExpression _alternative2;

        public AlternationExpression(RegularExpression alternative1, RegularExpression alternative2)
        {
            this._alternative1 = alternative1;
            this._alternative2 = alternative2;
        }

        public override void Interpret()
        {
            throw new NotImplementedException();
        }
    }
}

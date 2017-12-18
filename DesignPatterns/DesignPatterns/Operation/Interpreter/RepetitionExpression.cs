using System;

namespace DesignPatterns.Operation.Interpreter
{
    /// <summary>
    /// Non terminal expression
    /// </summary>
    public class RepetitionExpression : RegularExpression
    {
        public RepetitionExpression(int times, RegularExpression expression)
        {
        }

        public override void Interpret()
        {
            throw new NotImplementedException();
        }
    }
}

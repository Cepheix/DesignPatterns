namespace DesignPatterns.Operation.Interpreter
{
    /// <summary>
    /// Client
    /// </summary>
    public class Document
    {
        public void FindExpression()
        {
            RegularExpression literal1 = new LiteralExpression("psy");
            RegularExpression literal2 = new LiteralExpression("koty");

            RegularExpression alternative = new AlternationExpression(literal1, literal2);

            RegularExpression repetitionExpression = new RepetitionExpression(2, alternative);

            RegularExpression literal3 = new LiteralExpression("deszcz");

            RegularExpression sequence = new SequenceExpression(literal3, repetitionExpression);

            sequence.Interpret();
        }
    }
}

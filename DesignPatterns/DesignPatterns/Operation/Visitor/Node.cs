namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// Element interface
    /// </summary>
    public abstract class Node
    {
        public abstract void Accept(NodeVisitor visitor);
    }
}

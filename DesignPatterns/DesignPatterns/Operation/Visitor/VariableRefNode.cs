namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// Concrete element
    /// </summary>
    public class VariableRefNode : Node
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitVariableNode(this);
        }
    }
}

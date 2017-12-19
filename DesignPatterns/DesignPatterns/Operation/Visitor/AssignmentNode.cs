namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// concrete element
    /// </summary>
    public class AssignmentNode : Node
    {
        public override void Accept(NodeVisitor visitor)
        {
            visitor.VisitAssignmentNode(this);
        }
    }
}

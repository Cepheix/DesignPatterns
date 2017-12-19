namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// Visitor interface
    /// </summary>
    public abstract class NodeVisitor
    {
        public abstract void VisitAssignmentNode(AssignmentNode assignmentNode);

        public abstract void VisitVariableNode(VariableRefNode variableRefNode);
    }
}

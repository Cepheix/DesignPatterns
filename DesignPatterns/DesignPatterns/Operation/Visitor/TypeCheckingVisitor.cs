namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// Concrete visitor
    /// </summary>
    public class TypeCheckingVisitor : NodeVisitor
    {
        public override void VisitAssignmentNode(AssignmentNode assignmentNode)
        {
            // add type checking functionality
        }

        public override void VisitVariableNode(VariableRefNode variableRefNode)
        {
            // add type checking functionality
        }
    }
}

namespace DesignPatterns.Operation.Visitor
{
    /// <summary>
    /// Concrete visitor
    /// </summary>
    public class CodeGeneratingVisitor : NodeVisitor
    {
        public override void VisitAssignmentNode(AssignmentNode assignmentNode)
        {
            // add code generating functionality
        }

        public override void VisitVariableNode(VariableRefNode variableRefNode)
        {
            // add code generating functionality
        }
    }
}

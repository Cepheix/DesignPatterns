namespace DesignPatterns.Operation.Visitor
{
    public class Program
    {
        public void Run()
        {
            CodeGeneratingVisitor codeGeneratingVisitor = new CodeGeneratingVisitor();
            TypeCheckingVisitor typeCheckingVisitor = new TypeCheckingVisitor();

            VariableRefNode variableNode = new VariableRefNode();

            variableNode.Accept(codeGeneratingVisitor); // added code generating functionality
            variableNode.Accept(typeCheckingVisitor); // added type checking functionality
        }
    }
}

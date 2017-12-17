using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Facade class
    /// </summary>
    public class Compiler
    {
        public void Compile(InputStream input, BytecodeStream output)
        {
            Scanner scanner = new Scanner(input);
            ProgramNodeBuilder builder = new ProgramNodeBuilder();
            Parser parser = new Parser();

            parser.Parse(scanner, builder);

            StackMachineCodeGenerator generator = new StackMachineCodeGenerator(output);

            ProgramNode parseTree = builder.GetRootNode();
            parseTree.Traverse(generator);
        }
    }
}

using System;

namespace DesignPatterns.Operation.Strategy
{
    public class Client
    {
        public void Run(string type)
        {
            Compositor compositor;

            switch (type)
            {
                case "simple":
                    compositor = new SimpleCompositor();
                    break;
                case "array":
                    compositor = new ArrayCompositor();
                    break;
                case "tex":
                    compositor = new TeXCompositor();
                    break;
                default:
                    throw new Exception();
            }

                Composition composition = new Composition(compositor);

                composition.Repair();
        }
    }
}

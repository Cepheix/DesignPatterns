using System;

namespace DesignPatterns.Structural.VirtualProxy
{
    public class Image : Graphic
    {
        public override void Draw()
        {
            // long operation
        }

        public override string GetExtension()
        {
            return "jpeg";
        }

        public override void Load()
        {
            // long operation
        }

        public override void Store()
        {
            // long operation
        }
    }
}

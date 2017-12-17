using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.VirtualProxy
{
    public class DocumentEditor
    {
        public void Draw()
        {
            List<Graphic> graphics = new List<Graphic>()
            {
                new ImageProxy("pic1"),
                new ImageProxy("pic2"),
                new ImageProxy("pic3")
            };

            foreach (Graphic graphic in graphics)
            {
                graphic.Draw();
            }
        }
    }
}

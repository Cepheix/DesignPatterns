using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Construct.Prototype
{
    class GraphicTool : Tool
    {
        private readonly Graphic _prototype;

        public GraphicTool(Graphic graphic)
        {
            this._prototype = graphic;
        }

        public void Manipulate()
        {
            Graphic proto = this._prototype.Clone();

            while (UserMovingMouse())
            {
                proto.Draw(GetMousePosX(), GetMousePosY());
            }
        }

        private int GetMousePosX()
        {
            throw new NotImplementedException();
        }

        private int GetMousePosY()
        {
            throw new NotImplementedException();
        }

        private bool UserMovingMouse()
        {
            throw new NotImplementedException();
        }
    }
}

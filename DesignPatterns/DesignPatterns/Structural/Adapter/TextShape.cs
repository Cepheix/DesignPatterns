using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class TextShape : Shape
    {
        private readonly TextView _textView;

        public TextShape(TextView textView)
        {
            this._textView = textView;
        }

        public void BoundingBox()
        {
            this._textView.OtherApiBoundingBox();
        }

        public void CreateManipulator()
        {
            this._textView.OtherApiCreateManipulator();
        }
    }
}

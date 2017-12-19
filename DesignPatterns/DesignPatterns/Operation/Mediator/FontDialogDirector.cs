using System;

namespace DesignPatterns.Operation.Mediator
{
    /// <summary>
    /// concrete mediator
    /// </summary>
    public class FontDialogDirector : DialogDirector
    {
        private ListBox _listBox;
        private TextBox _textBox;

        public override void CreateWidgets()
        {
            _listBox = new ListBox(this);
            _textBox = new TextBox(this);
        }

        public override void WidgetChanged(Widget widget)
        {
            if (widget is ListBox)
            {
                this._textBox.SetText(String.Format("you selected option: {0}", this._listBox.GetSelected()));
            }

        }
    }
}

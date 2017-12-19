namespace DesignPatterns.Operation.Mediator
{
    /// <summary>
    /// concrete colleague
    /// </summary>
    public class TextBox : Widget
    {
        private string _text;

        public TextBox(DialogDirector director) : base(director)
        {
        }

        public string GetText()
        {
            return this._text;
        }

        public void SetText(string text)
        {
            this._text = text;
            this.Changed();
        }
    }
}

namespace DesignPatterns.Operation.Mediator
{
    /// <summary>
    /// concrete colleague
    /// </summary>
    public class ListBox : Widget
    {
        private int _optionSelected;

        public ListBox(DialogDirector director) : base(director)
        {
        }

        public void SelectOption(int option)
        {
            this._optionSelected = option;
            this.Changed();
        }

        public int GetSelected()
        {
            return this._optionSelected;
        }


    }
}

namespace DesignPatterns.Operation.Mediator
{
    /// <summary>
    /// colleague
    /// </summary>
    public abstract class Widget
    {
        private readonly DialogDirector _director;

        protected Widget(DialogDirector director)
        {
            this._director = director;
        }

        public virtual void Changed()
        {
            this._director.WidgetChanged(this);
        }
    }
}

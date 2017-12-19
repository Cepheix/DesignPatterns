namespace DesignPatterns.Operation.Mediator
{
    /// <summary>
    /// mediator
    /// </summary>
    public abstract class DialogDirector
    {
        public abstract void WidgetChanged(Widget widget);
        public abstract void CreateWidgets();
    }
}

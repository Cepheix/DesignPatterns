using System.Collections.Generic;

namespace DesignPatterns.Structural.Observer
{
    /// <summary>
    /// subject interface
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> _observers;

        protected void Attach(Observer observer)
        {
            this._observers.Add(observer);
        }

        protected void Detach(Observer observer)
        {
            this._observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer observer in this._observers)
            {
                observer.Update();
            }
        }
    }
}

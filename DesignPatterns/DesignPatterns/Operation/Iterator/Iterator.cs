namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// Iterator interface provides api to iterate over collection in predictable way
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Iterator<T>
    {
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();

        public abstract T CurrentItem();
    }
}

namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// base interface for a collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ListBase<T>
    {
        public abstract T Get(int index);

        public abstract int Length();

        public abstract Iterator<T> GetIterator();
    }
}

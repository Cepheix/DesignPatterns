namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// concrete collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayList<T> : ListBase<T>
    {
        private readonly T[] _list;

        public ArrayList(int size)
        {
            this._list = new T[size];
        }

        public override T Get(int index)
        {
            return _list[index];
        }

        public override int Length()
        {
            return this._list.Length;
        }

        public override Iterator<T> GetIterator()
        {
            return new ArrayListIterator<T>(this);
        }
    }
}

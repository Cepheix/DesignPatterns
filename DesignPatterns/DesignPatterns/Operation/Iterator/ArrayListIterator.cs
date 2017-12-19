namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// concrete iterator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayListIterator<T> : Iterator<T>
    {
        private readonly ArrayList<T> _list;
        private int _index;

        public ArrayListIterator(ArrayList<T> list)
        {
            this._list = list;
            this._index = 0;
        }

        public override T CurrentItem()
        {
            return this._list.Get(_index);
        }

        public override void First()
        {
            this._index = 0;
        }

        public override bool IsDone()
        {
            return this._index == this._list.Length();
        }

        public override void Next()
        {
            this._index++;
        }
    }
}

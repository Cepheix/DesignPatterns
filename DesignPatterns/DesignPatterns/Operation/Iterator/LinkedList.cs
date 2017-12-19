using System;

namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// concrete collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : ListBase<T>
    {
        public override T Get(int index)
        {
            throw new NotImplementedException();
        }

        public override Iterator<T> GetIterator()
        {
            throw new NotImplementedException();
        }

        public override int Length()
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace DesignPatterns.Operation.Iterator
{
    /// <summary>
    /// concrete iterator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListIterator<T> : Iterator<T>
    {
        public override T CurrentItem()
        {
            throw new NotImplementedException();
        }

        public override void First()
        {
            throw new NotImplementedException();
        }

        public override bool IsDone()
        {
            throw new NotImplementedException();
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}

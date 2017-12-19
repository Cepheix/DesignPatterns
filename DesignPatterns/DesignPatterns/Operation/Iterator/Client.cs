using System;

namespace DesignPatterns.Operation.Iterator
{
    public class Client
    {
        public void Read(string type)
        {
            ListBase<string> list;

            if (type == "array")
            {
                list = new ArrayList<string>(5);
            }
            else
            {
                list = new LinkedList<string>();
            }

            Iterator<string> iterator = list.GetIterator();
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                Console.WriteLine(iterator.CurrentItem());
            }
        }
    }
}

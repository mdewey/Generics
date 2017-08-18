using System;
using System.Linq;
using System.Collections.Generic;
namespace Generics
{
    // This is a FIFO structure, useful for notifications 
    // and transactions and ordering tasks
    public class Queue<T> //where T: ICanFly
    {
        private IList<T> queue = new List<T>();

        // remove item from queue
        public T Pop() {
            var item = queue.First();
            //    item.Fly();
            queue.RemoveAt(0);
            return item;
        }

        // add item to end of queue
        public void Push(T item) => queue.Add(item);
        public bool Peek { get => queue.Any(); }

    }
}
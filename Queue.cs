using System;
using System.Linq;
using System.Collections.Generic;
namespace Queue
{
    // This is a FIFO structure, useful for notifications 
    // and transactions and ordering tasks
    public class Queue<T>
    {
        private IList<T> queue = new List<T>();

        // remove item from queue
        public T Pop() {
            var item = queue.First();
            queue.RemoveAt(0);
            return item;
        }

        // add item to end of queue
        public void Push(T item) => queue.Add(item);


    }
}
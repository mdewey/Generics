using System;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
    // This is a FIFO structure, useful for notifications 
    // and transactions and ordering tasks

    public class Queue <T> where T : ICanGallop
    {
        private IList<T> queue = new List<T>();

        public void Enqueue(T item)
        {
            this.queue.Add(item);
            item.DecreaseSpeed(100);
        }

        public T Dequeue()
        {
            var rv = this.queue.First();
            this.queue.RemoveAt(0);
            return rv;
        }
    }
}
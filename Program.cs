using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new Queue<string>();

            messages.Push("hello");
            messages.Push("world");
            messages.Push("what ");
            messages.Push("a ");
            messages.Push("nice");
            messages.Push("day");
            messages.Push("we");
            messages.Push("have ");
            messages.Push("today");

            while (messages.Peek)
            {
                Console.WriteLine(messages.Pop());
            }


            var tickets = new Queue<int>();
            tickets.Push(10);
            tickets.Push(9);
            tickets.Push(8);
            tickets.Push(7);
            tickets.Push(6);
            tickets.Push(5); 
            tickets.Push(4);

        }
    }
}

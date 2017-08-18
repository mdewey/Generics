using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new Queue<int>();

            numbers.Enqueue(5);
            numbers.Enqueue(10);

            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine(numbers.Dequeue());



            var message = new Queue<string>();

            message.Enqueue("Hello Betty");
            message.Enqueue("How are you?!");

            Console.WriteLine(message.Dequeue());
            Console.WriteLine(message.Dequeue());


            var bools = new Queue<bool>();

            var lists = new Queue<List<string>>();

        }
    }
}

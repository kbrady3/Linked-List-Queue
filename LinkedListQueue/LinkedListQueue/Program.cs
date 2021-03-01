using System;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(2);

            Console.WriteLine("Is empty at beginning: " + q.IsEmpty());
            q.Enqueue("First");
            q.Enqueue("Second");
            Console.WriteLine("Is full after 2 enqueues: " + q.IsFull());
            Console.WriteLine(q.PrintQueue());
            Console.WriteLine("Peek: " + q.Peek());
            Console.WriteLine("Size: " + q.Size());
        }
    }
}

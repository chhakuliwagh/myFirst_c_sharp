using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_queue_Ex1
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Diapli");
            queue.Enqueue("Apeksha");
            queue.Enqueue("Mansi");
            queue.Enqueue("Shreya");
            queue.Enqueue("Prachi");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");

            // Dequeue
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");

            //Count
            Console.WriteLine("Count Total Elemt: "+ queue.Count);
            Console.WriteLine("-----------------------------------");

            // Dequeue
            queue.Enqueue("Lokesh");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
        }
    }
}

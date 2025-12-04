using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_queue_Ex2
    {
        static void Main(string[] args)
        {

            Queue queue = new Queue();
            int choice;
            do
            {
                Console.WriteLine("\n ========Stack Menu========");
                Console.WriteLine("1. Push Element ");
                Console.WriteLine("2. Pop Element ");
                Console.WriteLine("3. Peek Element ");
                Console.WriteLine("4. Display Element ");
                Console.WriteLine("5. Check Element (Contains)");
                Console.WriteLine("6. Total Element ");
                Console.WriteLine("7. Clear Stack ");
                Console.WriteLine("8.  Exit");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input,Please a Number (1-8)");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("Enter Element TO Push: ");
                        string input = Console.ReadLine();
                        queue.Enqueue(input);
                        Console.WriteLine($"{input} pushed to stack");
                        break;

                    case 2:
                        if (queue.Count > 0)
                        {
                            var popped = queue.Dequeue();
                            Console.WriteLine($"Poped elemt: {popped}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty: ");
                        }
                        break;
                    case 3:
                        if (queue.Count > 0)
                        {
                            var top = queue.Peek();
                            Console.WriteLine($"Top Peek element: {top}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty: ");
                        }
                        break;

                    case 4:
                        if (queue.Count > 0)
                        {

                            Console.WriteLine($"Stack Element");
                            foreach (var item in queue)
                            {
                                Console.WriteLine(item);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty: ");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Ckeck Elements: ");
                        string check = Console.ReadLine();
                        bool exits = queue.Contains(check);
                        Console.WriteLine(exits ? "Element Found " : "Element Not Found");
                        break;
                    case 6:
                        Console.WriteLine($"Total Element is stack  + {queue.Count}");
                        break;
                    case 7:
                        queue.Clear();
                        Console.WriteLine("Stack Cleared");
                        break;
                    case 8:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
            while (choice != 8);
            // Console.ReadLine();
        }
    }
}

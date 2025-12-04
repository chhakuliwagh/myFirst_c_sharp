using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_stack_Ex2
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Diapli");
            mystack.Push("Mansi");
            mystack.Push("Apeksh");
            mystack.Push("Lokesh");
            mystack.Push("Tulsi");
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");

            mystack.Pop();
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

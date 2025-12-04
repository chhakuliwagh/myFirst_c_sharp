using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_stack_Ex1
    {
        
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Dipali");
            mystack.Push(20);
            mystack.Push(554.49);
            mystack.Push(1078);
            mystack.Push(true);
            mystack.Push("Wagh");
           
            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Total Count: "+ mystack.Count);
            Console.ReadLine(); 
        }
    }
}

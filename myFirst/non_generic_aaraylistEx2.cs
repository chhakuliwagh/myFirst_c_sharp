using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_aaraylistEx2
    {
        static void Example8_AddRange()
        {
            ArrayList list = new ArrayList();
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.AddRange(new string[] {"Dipali","Apeksha","priya","Line" });

            Console.WriteLine("Example 1: AddRange Example: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");
        }

        static void Example9_InsertRange()
        {
            ArrayList list = new ArrayList();
            list.InsertRange(1, new string[] {"A","B","C","D"});

            Console.WriteLine("Example 1: Insert Range Example: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");
        }
        static void Main(string[] args)
        {
            Example8_AddRange();
            Example9_InsertRange();
            Console.ReadLine();
        }
    }
}

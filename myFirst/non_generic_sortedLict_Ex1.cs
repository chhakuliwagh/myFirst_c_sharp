using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_sortedLict_Ex1
    {
        static void DisplayList(SortedList s1)
        {
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine($"ID : {item.Key} , Product Name: {item.Value}");

            }
        }
        static void Main(string[] args)
        {
            SortedList s1= new SortedList();
            s1.Add(3,"A");
            s1.Add(5,"B");
            s1.Add(1,"C");
            s1.Add(4,"D");
            s1.Add(2,"E");
            Console.WriteLine("========Sorted List=========");
            DisplayList(s1);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("value Of Key: "+ s1[3]);
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Value At Index: "+s1.GetByIndex(1));
            Console.WriteLine("---------------------------------------");


            s1[2] = "Dipali";
            DisplayList(s1);

            Console.WriteLine("---------------------------------------");


            s1.RemoveAt(0);
            DisplayList(s1);

            Console.WriteLine("---------------------------------------");

          

            
            Console.WriteLine($"\n Total Products: {s1.Count}");
            Console.WriteLine("---------------------------------------");


            if (s1.ContainsKey(5))
            {
                Console.WriteLine("List Key exits");

            }
            else
            {
                Console.WriteLine("List Key does Not exits..");
            }

            Console.WriteLine("---------------------------------------");



            if (s1.ContainsValue("G"))
            {
                Console.WriteLine("List name exits");

            }
            else
            {
                Console.WriteLine("List name does Not exits..");
            }

            Console.WriteLine("---------------------------------------");

           s1.Clear();
            Console.WriteLine($"\n Total Products: {s1.Count}");






            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class student
    {
        public string Name;
        public int Age;
    }
    internal class non_generic_arraylistEx1
    {
        static void Example1_StoreDifferentDataTypes()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Dipali");
            list.Add(55.6);
            list.Add("Wagh");

            Console.WriteLine("Example 1: Storing Different data type");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");
        }
        static void Example2_RemoveInsertItems()
        {
            ArrayList fruitlis = new ArrayList();
            fruitlis.Add("Banana");
            fruitlis.Add("Apple");
            fruitlis.Add("Mango");
            fruitlis.Add("grapse");
            fruitlis.Add("PinApple");

            fruitlis.AddRange(new int[] { 100,200,300});
            

            fruitlis.RemoveAt(2);              // Remove At index
            fruitlis.Remove("Banana");        //remove by value
            fruitlis.Insert(1, "Orange");    // Inser(Indexing,value)
            fruitlis.Insert(2,"Banana");

            fruitlis.InsertRange(4, new string[] {"Kevi"});           //Inser value using : InsertRange

            fruitlis.RemoveRange(1,2);    // remove value using : RemoveRange
          

            Console.WriteLine("Example 2: Storing Different data type");
            foreach (object item in fruitlis)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
        }
        static void Example3_ShortingItems()
        {
            ArrayList number = new ArrayList() { 5,3,4,7,8,9};
            number.Sort();

            Console.WriteLine("Example 3: Shorting Number");
            foreach(object num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------------------------------");
        }
        static void Example4_SearchingElements()
        {
            ArrayList names = new ArrayList() { "Anand","Kalpesh","Dipak","Aakash"};


            Console.WriteLine("Example 4: Searching elements");

           if(names.Contains("Dipali"))   //Searching Use = Contains ,,,,Wrong Spelling 
            {
                Console.WriteLine("this Name is Our Name List");
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
                Console.WriteLine("-------------------------------------");
        }
        static void Example5_CopyToArray()
        {
            ArrayList city = new ArrayList() {"Mumbai","Chennai","Pune","Shirpur"};

            string[] cityArray = new string[city.Count];
            city.CopyTo(cityArray);

            Console.WriteLine("Example 5: Copy Elements");


            foreach (string cities in cityArray)
            {
                Console.WriteLine(cities);
            }
            Console.WriteLine("-------------------------------------");

        }

        static void Example6_ReversItems()
        {
            ArrayList number = new ArrayList() { 5, 3, 4, 7, 8, 9 };
            number.Reverse();

            Console.WriteLine("Example 6: Reverse Number");


           // Console.WriteLine("Example 3: Revers Number");
            foreach (object num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------------------------------");
        }

        static void Example7_UsingObject()
        {
            ArrayList students = new ArrayList();
            students.Add(new student { Name = "dipali", Age = 25 });
            students.Add(new student { Name = "Lokesh", Age = 22 });

            Console.WriteLine("Example 7: Array List Usimg Object ");


            foreach (student s in students)
                {
              
                Console.WriteLine($"{s.Name} - {s.Age}");
                }
        }
        static void Main(string[] args)
        {
            Example1_StoreDifferentDataTypes();

            Example2_RemoveInsertItems();

            Example3_ShortingItems();

            Example5_CopyToArray();

            Example6_ReversItems();

            Example7_UsingObject();
           


            Example4_SearchingElements();
            Console.ReadLine(); 
        }
    }
}

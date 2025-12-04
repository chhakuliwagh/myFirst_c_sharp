using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class datatype
    {

        static void Main(string[] args)
        {
            int age = 25;  //Integertype
            float height = 5.9f; //floating value
            double weight = 0.12d;
            decimal c = 1.8989898989998m; //29 value we can store
            char grade = 'A';
            bool isStudent = true;

            //reference Type
            string name = "Dipali";

            object anything = 11;  // object hold anything value(both int ,string )
            Console.WriteLine("age is" + age);
            Console.WriteLine("height is" + height);
            Console.WriteLine("weigght is" + weight);
            Console.WriteLine("decimal c is" + c);
            Console.WriteLine("grade is" + grade);
            Console.WriteLine("Student is" + isStudent);
            Console.WriteLine("name is" +name);
            Console.ReadLine();
        }
    }
}

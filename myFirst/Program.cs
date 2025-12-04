using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Program
    {
       static void Main(string[] args)   // main method
        {
            //    Console.WriteLine("Welcome to c#");     // use for output print
            //    Console.WriteLine("Welcome to FCT");
            //    Console.WriteLine("Enter Your Name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter your Address: ");
            //    string address = Console.ReadLine();

            //    Console.WriteLine(" My name is " + name + "My address is "+ address); //concatination

            //    Console.WriteLine("My name is {0} and my addressis is {1}",name , address);  //placeholder

            //    Console.WriteLine($"my name is{name} and my address is {address}");     //string interpolution:  $:- String interpolation lets you insert variables directly inside a string without using + to concatenate. 
            //    Console.ReadLine();


            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum=num1 + num2;
            Console.WriteLine($"Sum is: {sum} ");
        }
    }
}

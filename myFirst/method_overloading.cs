using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class method_overloading
    {
        public void Addition()
        {
            int a = 10;
            int b = 20;
            int c = a+b;
            Console.WriteLine(c);
        }
        public void Addition(int a,int b)
        { 
            int c = a+b;
            Console.WriteLine(c);
        }
        public void Addition(int a, int b,int c)
        {
            double d= a + b+c;
            Console.WriteLine(c);
        }
        public void Addition(int a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
        public void Addition(double a, int b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
        public void Addition(float a, int b)
        {
            double c = a + b;
        Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            method_overloading m1 = new method_overloading(); 
            m1.Addition();         //First method call
            m1.Addition(20,30);   //Second method 
            m1.Addition(20,30.5);   // third method call
            m1.Addition(10.5, 30);
            m1.Addition(15.67, 40);
            Console.ReadLine();
        }
    }
}

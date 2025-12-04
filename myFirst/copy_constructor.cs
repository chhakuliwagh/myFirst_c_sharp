using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
   
    internal class copy_constructor
    {
        string Name;
        int Age;
        public  copy_constructor(string name,int age)
        {
            Name = name;
            Age = age;

        }
        public  copy_constructor(copy_constructor c)
        {
           this.Name =c.Name;
            this.Age = c.Age;

        }
        public void displayDetails()
        {
            Console.WriteLine($"Name: {Name},Age: {Age}");
        }
        static void Main(string[] args)
        {
            copy_constructor c = new copy_constructor("Dipali",21);
            c.displayDetails();
            copy_constructor c1=new copy_constructor(c);
            Console.ReadLine();
        }
    }
}

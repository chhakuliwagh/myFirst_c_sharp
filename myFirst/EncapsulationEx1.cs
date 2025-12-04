using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myFirst
{
    class Person11
    {
        //public string name;
        //public int age;

        private string name;
        private int age;
        private double marks;

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name)== true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.name= name;
            }
        }
        public void getName()
        {
            if(string.IsNullOrEmpty (name)!= true)
            {
                Console.WriteLine("Your Name Is :" + this.name);
            }
        }

        public void setAge(int age)
        {
            if(age <0)
            {
                Console.WriteLine("Age can not be nefative");
            }
            else
            {
                this.age = age;
            }
        }
        public void getAge()
        {
            if(this.age>0)
            {
                Console.WriteLine("Your Age Is : "+ this.age);
            }
           
        }

        public void setMarks(double marks)
        {
            if(marks <0 || marks >100)
            {
                Console.WriteLine("Please Enter 0 To 100");
            }
            else
            {
                this.marks = marks;
            }
        }
        public void getMarks()
        {
            if(this.marks<100)
            {
                Console.WriteLine("Your Marks Is: " + this.marks);
            }
        }
}

    internal class EncapsulationEx1
    {
        static void Main(string[] args)
        {
            Person11 p = new Person11();
            p.setName("Dipali");
            p.getName();

            p.setAge(21);
            p.getAge();

            p.setMarks(55);
            p.getMarks();

        //    Person11 p = new Person11();
        //    p.name="Dipali";
        //    p.age = 21;

        //    Console.WriteLine(p.name);
        //    Console.WriteLine(p.age);
        //    Console.ReadLine(); 
        }
    }
}

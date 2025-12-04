using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    // Abstract Class
    abstract class persona101
    {
        public string name;
        public int age;
        public long phoneNumber;
        public string qualification;
        public int salary;
        public int id;

        public abstract void printDetails();    // abstract metho without body
        public void display()
        {
            Console.WriteLine("This is non abstract method");
            
        }

    }
    class student101 : persona101
    {
        public int RollNo;
        public int fees;

        public override void printDetails()
        {
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Age: {age}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Student Roll No. {RollNo} and Fees - {fees}");

        }
    }
    class teacher : persona101
    {
        //public string qualification;
        //public int salary;
       

        public override void printDetails()
        {
            Console.WriteLine($"Teacher Qualification: {qualification}");
            Console.WriteLine($"Salary: {salary}");
          

        }
    }
    class employee: persona101
    {
        //public string name;
        //public int id;


        public override void printDetails()
        {
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Employee id: {id}");


        }
    }
    internal class abstraction_ex1
    {
        static void Main(string[] args)
        {
            student101 s1=new student101();
            s1.name = "Dipali";
            s1.age = 21;
            s1.phoneNumber = 4557783423;
            s1.fees = 190;
            s1.RollNo = 91;
            s1.printDetails();
            Console.WriteLine("--------------------------------");

            teacher t1=new teacher();
            t1.qualification = "Post graduate";
            t1.salary = 40000;
            t1.printDetails();
            Console.WriteLine("--------------------------------");

            employee e1 = new employee();
            e1.name = "Suresh";
            e1.id = 101;
            e1.printDetails();
           
            Console.WriteLine("--------------------------------");
            persona101 p = new student101();
            p.display();     // upcasting method ,,, run time execution 
          //  p.printDetails();

            Console.ReadLine();

        }
    }
}

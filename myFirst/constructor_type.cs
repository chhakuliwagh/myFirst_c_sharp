using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    
    internal class constructor_type
    {
        //public constructor_type()  //default constructor
        //{
        //    Console.WriteLine("Default Constructor: ");
        //}
        string Name;
        int EmpId;
        int Age;
        int Salary;
        public constructor_type(string name,int empid,int empage,int empsalary)  //parameterize constructor
        {
            Name = name;
            EmpId = empid;
            Age = empage;
            Salary = empsalary;
        }
        //public string getName()
        //{
        //    return Name;
        //}
        //public int getEmpId()
        //{
        //    return EmpId;
        //}
        //public int getAge()
        //{
        //    return Age;
        //}
        //public int getSlary()
        //{
        //    return Salary;
        //}
        //public string getDetails()
        //{
        //    return $"Name: {Name},Emp Id: {EmpId},Age: {Age},Salary: {Salary}";
        //}
        public void displayDetails()
        {
         
            Console.WriteLine($"Name: {Name},Emp Id: {EmpId},Age: {Age},Salary: {Salary}");
        }
        static void Main(string[] args)
        {
            //constructor_type c1 = new constructor_type();
            constructor_type c2 = new constructor_type("Dipali",101,34,50000);
            constructor_type c3 = new constructor_type("Lokesh", 102, 35, 5000000);
            //Console.WriteLine($"Emp Name: {c2.getName()}");
            //Console.WriteLine($"Emp Id: {c2.getEmpId()}");
            //Console.WriteLine($"Emp Age: {c2.getAge()}");
            //Console.WriteLine($"Emp Salary: {c2.getSlary()}");
            //Console.WriteLine($"Emp Salary: {c2.getDetails()}");
            c2.displayDetails();
            c3.displayDetails();
            Console.ReadLine();
            

            }
    }
}

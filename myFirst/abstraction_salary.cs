using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class Employee
    {
        public string name;
        public int age;

        public double GrossSalary;
        double taxDeduction = 0.1;  // 0.1 means = 10%
        double netSalary;

        public Employee(string name, int age, double grossSalary)
        {
            this.name = name;
            this.age = age;
            this.GrossSalary = grossSalary;
          
        }
       private void CalculateSalary()
        {
            if (GrossSalary > 30000)
            {
                netSalary = GrossSalary - (taxDeduction * GrossSalary);
                Console.WriteLine($"You net salary{netSalary}");
            }
            else
            {
                Console.WriteLine($"Your net salary: {GrossSalary}");
            }
        }
        public void showEmployeeDetail()
        {
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Employee Age : {age}");
            this.CalculateSalary();
        }
    }
    internal class abstraction_salary
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Dipali",23,40000);
            e1.showEmployeeDetail();
            Employee e2 = new Employee("Dipali", 25, 20000);
            e2.showEmployeeDetail();
            Console.ReadLine();

        }
    }
}

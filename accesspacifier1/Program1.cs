using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesspacifier1
{
    public class Class1
    {
        public void show1()
        {
            Console.WriteLine("Accessing Public Mehtod");
        }
        //public void show2()  // Currunt Class
        //{
        //    Class1 obj=new Class1();
        //    obj.show1();
        //}
    }
    public class Program1 : Class1
    {
        static void Main(string[] args)
        {
            //Class1 obj=new Class1();
            //obj.show2();

            Program1 pg= new Program1();
            pg.show1();
            Console.ReadLine(); 
        }
    }
}

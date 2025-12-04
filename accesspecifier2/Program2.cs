using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesspacifier1;

namespace accesspecifier2
{
    //internal class Program2
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("This is Second Project");
    //        Class1 obj=new Class1();
    //        obj.show1();
    //        Console.ReadLine();
    //    }
    //}


    internal class Program2 :Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Second Project - using derived class");
            Program2 obj = new Program2();
            obj.show1();
            Console.ReadLine();
        }
    }
}

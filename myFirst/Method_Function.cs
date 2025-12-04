using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Method_Function
    {
        public void showdataStudenDegreeData()  // non-static // instatnce method  // non paramterize
        {
            Console.WriteLine("Welcome");
        }
        public static void show1()  // non-static // instatnce method  // non paramterize
        {
            Console.WriteLine("Dipali");
        }
        static void Main(string[] args)
            {
                Method_Function mf= new Method_Function();
                mf.showdataStudenDegreeData();

                Method_Function.show1();

            Console.ReadLine();

            }
    }
}

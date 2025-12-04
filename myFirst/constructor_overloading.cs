using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class constructor_overloading
    {
        public constructor_overloading()
        {
            Console.WriteLine("First Default Constructor: ");
        }
        public constructor_overloading(int a,int b)
        {
            Console.WriteLine($"Second parametrize Constructor Addition: {a+b}");
        }
        public constructor_overloading(int a, int b,string c)
        {
            Console.WriteLine($"Second parametrize Constructor Addition: {a + b} {c}");
        }
        public constructor_overloading(int a, int b, string c,float d)
        {
            Console.WriteLine($"Second parametrize Constructor Addition: {a + b} {c} {d}");
        }

        static void Main(string[] args)
        {
            constructor_overloading c = new constructor_overloading();
            constructor_overloading c1 = new constructor_overloading(40,50);
            constructor_overloading c2 = new constructor_overloading(40, 55,"Dipu");
            constructor_overloading c3 = new constructor_overloading(40, 55, "Sonu",56.6f);
            Console.ReadLine();
        }
    }
}

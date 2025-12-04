using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class NewClass
    {
        public string str;
        public int num;

        public static NewClass operator + (NewClass c1, NewClass c2)
        { 
            NewClass obj3=new NewClass();
            obj3.str=c1.str + c2.str;
            obj3.num=c1.num + c2.num;
            return obj3;
        }
    }
    internal class operator_overloading
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            NewClass obj2 = new NewClass();
            NewClass obj3 = new NewClass();
            NewClass obj4= new NewClass();

            obj1.str = "Fortune";
            obj1.num= 10;

            obj2.str = " Cloud";
            obj2.num= 20;

            obj4.str = " Pimpri";
            obj4.num= 30;

            obj3 = obj1 + obj2+obj4;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);
        }
    }
}

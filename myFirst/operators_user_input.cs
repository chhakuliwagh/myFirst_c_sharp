using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class operators_user_input
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter first number (a)");
            //int a=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter second number (b)");
            //int b=Convert.ToInt32(Console.ReadLine());

            int a = 30;
            int b = 20;

            Console.WriteLine("\n=================");
            Console.WriteLine("Arithmatic Operator");
            Console.WriteLine("\n=================");

            Console.WriteLine($"a+b={a+b}");   //Arithmatic operator
            Console.WriteLine($"a-b={a-b}");    //substraction
            Console.WriteLine($"a*b={a * b}");   //multiplication 
            Console.WriteLine($"a/b={a / b}");    //division   
            Console.WriteLine($"a%b={a % b}");   //module

            Console.WriteLine("\n===============");


            Console.WriteLine("Relatiob operator");
            Console.WriteLine("\n==============");

            Console.WriteLine($"a==b:{a == b}");   //Arithmatic operator
            Console.WriteLine($"a<b:{a < b}");    //substraction
            Console.WriteLine($"a>b:{a > b}");   //multiplication 
            Console.WriteLine($"a<=b:{a <= b}");    //division   
            Console.WriteLine($"a=>b;{a>=b}");
            Console.WriteLine($"a!=b;{a !=b}");

            Console.WriteLine("\n===============");

            Console.WriteLine("Logical operator");
            bool x = (a>0);
            bool y = (b>0);
            Console.WriteLine($"x && y ={ x && y}");
            Console.WriteLine($"x || y ={x || y}");
            Console.WriteLine($"!x=={!x}");

            Console.WriteLine("\n===============");

            Console.WriteLine("Assignment operator");
            Console.WriteLine("\n===============");

            int c = a;
            c += b;  //c=c+b
            Console.WriteLine($"c +=b:{c}");

            c -= b;
            Console.WriteLine($"c -=b:{c}");

            c *= b;
            Console.WriteLine($"c *=b:{c}");

            c /= b;
            Console.WriteLine($"c /=b:{c}");

            c %= b;
            Console.WriteLine($"c %=b:{c}");
            Console.WriteLine("\n===============");
            Console.WriteLine("Unary Operator");
            int num = a;
            Console.WriteLine($"num++={num++}");    
            Console.WriteLine($"++num={++num}");

            Console.WriteLine($"num--={num--}");
            Console.WriteLine($"--num={--num}");

            Console.WriteLine("\n===============");
            Console.WriteLine("Bitwise Operator");
            Console.WriteLine($"a & b ={a & b}");
            Console.WriteLine($"a | b ={a | b}");
            Console.WriteLine($"a ^ b ={a ^ b}");
            Console.WriteLine($" ~a  ={~a}");
            Console.WriteLine($"a >> b ={a >> 1}");
            Console.WriteLine($"a << b ={a << 1}");
            Console.WriteLine("\n===============");
            Console.WriteLine("TernaryOperator");
            string result = (a>b) ? "a is grater":"b is grater";
            Console.WriteLine(result);
            Console.WriteLine("\n===============");
            Console.ReadLine();
    }
    }
}

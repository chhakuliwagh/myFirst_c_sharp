using System;

namespace myFirst
{
    internal class function_type
    {
        // no parameter,, no return -- static method
        public static void showMessage()
        {
            Console.WriteLine("welcome Dipali" );
        }
        
        // no parameter,, no return -- non static method
        public  void showMessage1()
        {
            Console.WriteLine("welcome Apeksha" );
        }
        
        //with parameter ,,no return ,, static method
        public static void message(string name)
        {
            Console.WriteLine("Hello "+ name);
        }

        //with parameter ,,no return ,,non  static method
        public void message1(string name)
        {
            Console.WriteLine("Hello " + name );
        }

        // no parameter with return values using static
        public static int getNumber()
        {
            return 15;
        }

        // no parameter with return values using non static
        public int getNumber1()
        {
            return 20;
        }

        // with parameter  with , return - static

        public static int Add(int a, int b)
        {
            return a + b;
        }

        // with parameter  with , return -non  static

        public  int Sum(int a, int b,int c)
        {
            return a + b;
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        { 
           //Console.WriteLine("Enter Value of a: ");
           // int a=Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("Enter Value of b: ");
           // int b = Convert.ToInt32(Console.ReadLine());

           // int AddResult = Addition(a, b);
           // Console.WriteLine("Addition of a and b is= " +AddResult);

            // function_type.showMessage();
            // function_type f=new function_type();
            // f.showMessage1();
            // function_type.message("Gayatri");
            // function_type f1 = new function_type();
            //  f1.message1("Lokesh");
            // Console.WriteLine("Number Is " + getNumber()); // static
            // Console.WriteLine($"Number is " + f.getNumber1());   // non static
            // int sum = Add(23,45);
            //// Console.WriteLine("Sum is: " + sum);
            // Console.WriteLine($"Sum is: {sum}");
            // int Sum = f.Sum(45, 34, 67);
            // Console.WriteLine($"Addition of three number is: {Sum}");
        }


    }
}

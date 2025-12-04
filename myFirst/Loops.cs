using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //for loop
            //  Console.WriteLine("------For Loop-----");

            //for(int i = 1; i <=5;i++)
            //{
            //    Console.WriteLine("Number:"+i);
            //}


            //sum of first 10 natural number(1 to 10)
            //int sum=0;
            //for (int i = 1; i <= 10; i++)
            //{ 
            //   sum=sum+i;
            //}
            //Console.WriteLine("Total Sum: " + sum);



            // even number
            //int even;
            //for(int i=2; i<=20;i+=2)
            //{
            //    Console.WriteLine("Even Number: " + i);
            //}

            // Print Table
            //Console.WriteLine("enter Number For Multiplication Table");
            //int num=Convert.ToInt32(Console.ReadLine());

            //for (int i= 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num}x {i} = {num*i}" );
            //}

            //print table 1 to 10
            //Nested For Loop



            //while loop

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 2;
            //while (i <= 20)
            //{ 
            //Console.WriteLine(i);
            //    i += 2;
            //}

            //Console.WriteLine("Ente your Number");
            //int num=Convert.ToInt32(Console.ReadLine());

            //int i = 1, sum = 0;
            //while (i <= num)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Sum: " + sum);


            //reverse number
            //Console.WriteLine("Enter Number");
            //int num=Convert.ToInt32(Console.ReadLine());

            //int rev = 0;
            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    rev = (rev * 10) + digit;
            //    num /= 10;
            //}
            //Console.WriteLine("Reverse Number is: "+rev);

            //do-while
            Console.WriteLine("------do while Loop-----");
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 5);

            //string confirm;
            //do
            //{
            //    Console.WriteLine("Enter 1st number");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter 2nd number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int add = num1 + num2;
            //    Console.WriteLine("Addition Result is: " + add);

            //    Console.WriteLine("Do you want to really continue (yes/no)");
            //    confirm = Console.ReadLine();
            //}
            //while (confirm == "yes");
            //Console.WriteLine("Output of loop");

            int choice;
            do
            {
                Console.WriteLine("----MenuCommand----");
                Console.WriteLine("----1.Addition----");
                Console.WriteLine("----2.Substraction----");
                Console.WriteLine("----3.Exit----");
                //Console.WriteLine("----enter Your Choice----");
                //Console.WriteLine("----MenuCommand----");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter 1st number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    int num2 = int.Parse(Console.ReadLine());

                    int add = num1 + num2;
                    Console.WriteLine("Addition Result is: " + add);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter 1st number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    int num2 = int.Parse(Console.ReadLine());

                    int sub = num1 - num2;
                    Console.WriteLine("Addition Result is: " + sub);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Existing");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            while (choice != 3);
            



                Console.ReadLine();
        }
    }
}

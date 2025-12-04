using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class if_else_sta
    {
        static void Main(string[] args)
        {
            // if-else example 1
            //Console.WriteLine("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("Eligible for vote");
            //}
            //else
            //{ 
            //Console.WriteLine("Not Eligible for vote");
            //}



            // if-else example 2
            //Console.WriteLine("Enter Your Name");
            // string name = Console.ReadLine();
            //if (name == "Dipali")
            //{
            //Console.WriteLine("Hello..!!! Dipali");
            //}
            //else 
            //{
            //    Console.WriteLine("Who Are you");
            //}
            //

            // if-else example 3
            //Console.WriteLine("Enter Your User Name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Your Password");
            //string pass = Console.ReadLine();

            //if (name == "Dipali" && pass=="12345")
            //{
            //Console.WriteLine("Login Succesfully");
            //}
            //else 
            //{
            //    Console.WriteLine("Wrong credential");
            //}



            // if else_if example 4

            //Console.WriteLine("Enter Your Persantage");
            //int percent=int.Parse(Console.ReadLine());

            //if (percent >= 80)
            //{
            //    Console.WriteLine("Distinction");
            //}
            //else if(percent >= 75)
            //{
            //    Console.WriteLine("First Class");
            //}
            //else if (percent >= 55)
            //{
            //    Console.WriteLine("Second Class");
            //}
            //else if (percent >= 35)
            //{
            //    Console.WriteLine("Third Class");
            //}
            //else 
            //{
            //    Console.WriteLine("Fail");
            //}

            // Nested If else
            //Console.WriteLine("Enter User Name(email id):");
            //string user=Console.ReadLine();

            //if (user == "dipaliw24@gmail.com")
            //{
            //    Console.WriteLine("Enter Your Password");
            //    string pass = Console.ReadLine();
            //    if (pass == "12345")
            //    {
            //        Console.WriteLine("Login Succesfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Password");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong user name");
            //}

            // switch statement

            //Console.WriteLine("Enter Your Name:");
            //int WeekNumber=int.Parse(Console.ReadLine());

            //switch (WeekNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thrusday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid week Number");
            //        break;
            //}

            Console.WriteLine("Enter Your Pizza (corn,supreme,vegetable)");
            string pizza=Console.ReadLine();

            switch (pizza)
            {
                case "corn":
                    Console.WriteLine("Your corn pizza ready: ");
                    break;

                case "supreme":
                    Console.WriteLine("Your supreme pizza ready: ");
                    break;

                case "vegetable":

                    Console.WriteLine("Which vegetable pizza You have (onion,capsikum,garlic): ");
                    
                    string vegetable=Console.ReadLine();

                    switch (vegetable)
                    {
                        case "onion":
                            Console.WriteLine("Your Onio pizza");
                            break;

                        case "capsicum":
                            Console.WriteLine("Your Onio pizza");
                            break;

                        case "garlic":
                            Console.WriteLine("Your Onio pizza");
                            break;

                        default:
                            Console.WriteLine("Invalid vegetable");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid pizza");
                    break;
                    
            }
                Console.ReadLine(); 
        }
    }
}

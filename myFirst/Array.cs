using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    using System;

    internal class Array
    {
        static void Main(string[] args)
        {
            // initilization and decalaration
            //int[] numbers = { 10, 20, 30, 40, 50,60,70,80 };
            //Console.WriteLine("Array Elements:");

            //for (int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine($"Element at index {i} = {numbers[i]}");
            //}


            //int[] marks = new int[5];
            //Console.WriteLine("Enter Marks of 5 subject: ");


            //for(int i = 0; i < marks.Length; i++) 
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Enter Marks {i + 1}: ");
            //}
            //Console.WriteLine("Enter Marks ");
            //for(int i = 0;i < marks.Length;i++)
            //{
            //    Console.WriteLine($"subject {i+1} : {marks[i]}");
            //}

            // for each loop example

            //string[] names = { "Dipali", "Mansi","Gayatri","Apeksha","Sonali"};
            //Console.WriteLine("names in Array");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            // mix array using (object datatype)=Anything
            //

            //object[] mixed = { 1, "Dipali", 45.67,true };
            //Console.WriteLine("Mixed Array");
            //for (int i = 0; i < mixed.Length; i++) 
            //{
            //    Console.WriteLine(mixed[i]);
            //}

            //int[,] numbers = {
            //    { 1,2,3},
            //    { 4,5,6},
            //    { 7,8,9},
            //};
            //Console.WriteLine("2D array");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    { 
            //    Console.WriteLine(numbers[i,j] + "\t");    
            //    }
            //    Console.ReadLine();
            //}


            //int[,] marks = new int[2, 3];
            //Console.WriteLine("enter marks for 2 student (3 subject: ");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write($"student {i + 1}");

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"enter marks{j+1}: ");
            //        marks[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Marks enterd: ");
            //for(int i = 0;i < 2;i++)
            //{
            //    Console.WriteLine($"Student: {i+1}");
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.WriteLine(marks[i,j]+ "\t");
            //    }
            //}

            //Jagged array

            //int[][] arr = new int[3][];
            //arr[0] = new[] { 34, 54, 67, 56 };
            //arr[1] = new[] { 34, 13, 12, 23,67,89,45 };
            //arr[2] = new[] { 13, 14, 17 };

            ////Console.WriteLine(arr[1][4]);

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    { 
            //    Console.Write(arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            Console.WriteLine("Enter number of student");
          int studentCount=Convert.ToInt32(Console.ReadLine());

            int[][] studentMarks = new int[studentCount][];

            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("Enter Number Of Subject");
                int subjectCount=Convert.ToInt32(Console.ReadLine());

                studentMarks[i] = new int[subjectCount];
                for(int j=0;j<subjectCount;j++)
                {

                    Console.WriteLine($"Enter the marks of subject{j+i}");
                    studentMarks[i][j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Student Marks");
            for (int i = 0; i < studentMarks.Length; i++)
            {
               for(int j = 0; j < studentMarks[i].Length;j++)
                {
                    Console.Write(studentMarks[i][j] + "\t");
                }
                Console.WriteLine();
            }
           
           Console.ReadLine();

            



        }
    }
}


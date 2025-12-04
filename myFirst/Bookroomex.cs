using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class Bookroomex
    {
        public void Bookroom(string roomtype)
        { 
        Console.WriteLine($"Room Type {roomtype}");    
        }
        public void Bookroom(string roomtype,int guest)
        {
            Console.WriteLine($"Room type {roomtype} total guest {guest}");
        }
        public void  Bookroom(string roomtype,int guest,bool extrabed)
        {
            Console.WriteLine($"room type {roomtype} total guest {guest} extra bed {extrabed}");
        }
        static void Main(string[] args)
        {
            Bookroomex b1 = new Bookroomex();
            b1.Bookroom("Luxury");
            b1.Bookroom("Luxury",5);
           b1.Bookroom("Luxury",5,true);
            Console.ReadLine();
        }
    }
}

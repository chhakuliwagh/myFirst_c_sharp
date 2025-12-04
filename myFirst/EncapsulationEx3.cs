using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class HotelBooking
    {
        private string guestName;
        private int roomNumber;
        private int numberOfDay;
        private double roomRent;

        public void BookingDetails()
        {
            Console.WriteLine("Enter Guest Name: ");
            guestName = Console.ReadLine();

            Console.WriteLine("Enter Your Room Number: ");

            Console.WriteLine("Enter Your Number Of Day: ");

            Console.WriteLine("Enter Your Room Rent Per Day: ");
            roomRent = Convert.ToDouble(Console.ReadLine());
        }
        


    }
}
    internal class EncapsulationEx3
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
 }


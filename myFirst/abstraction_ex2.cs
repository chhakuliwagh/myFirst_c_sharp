using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{

    abstract class payment
    {
        public double amount;
        public string CustomerName;

        public void ShowBasicInfo()   // non abstract mehtod 
        {
            Console.WriteLine($"Customer name: {CustomerName} , Amount: {amount}");
        }
        public abstract void ProcessPayment();   // abstrct method
    }

    class CrediCardPayment : payment
    {
        public string cardNumber;

        public override void ProcessPayment()
        {
            Console.WriteLine($"Proccessing credit card payment using : {cardNumber}");
            Console.WriteLine("Cedit card payment successfully-");
        }

    }
    class UpiPayment : payment
    {
        public string upiId;

        public override void ProcessPayment()
        {
            Console.WriteLine($"Proccessing UPI  payment using: {upiId}");
            Console.WriteLine("UPI payment successfully- ");
        }

    }
    class NetBankingPayment : payment
    {
        public string Bank_Name;

        public override void ProcessPayment()
        {
            Console.WriteLine($"Proccessing Net banking  payment using : {Bank_Name}");
            Console.WriteLine("Net banking payment successfully- ");
        }

    }
    internal class abstraction_ex2
    {
        static void Main(string[] args)
        {

            payment p1 = new CrediCardPayment
            {
                CustomerName = "Dipali",
                amount = 12000,
                cardNumber = "23-6667-67878"

            };
            Console.WriteLine("-----------credit card payment----------");

            payment p2 = new UpiPayment
            {
                CustomerName = "Lokesh",
                amount = 5000,
                upiId = "dw@354565767"
            };

            payment p3 = new NetBankingPayment
            {
                CustomerName = "Lokesh",
                amount = 5000,
                Bank_Name= "State Bank Of India"
            };

            p1.ShowBasicInfo();
            p1.ProcessPayment();

            Console.WriteLine("-----------UPI payment----------");

            p2.ShowBasicInfo();
            p2.ProcessPayment();

            Console.WriteLine("-----------Net Banking payment----------");

            p3.ShowBasicInfo();
            p3.ProcessPayment();

            Console.ReadLine();

        }
    }
}

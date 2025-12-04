using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    public interface Ipayment
    {
        void pay(string from, string to, double amount);

        void sendReceipt(string to, double amount);

        void logPay(string method, string status, DateTime time);

    }

    public class CreditCardPayment : Ipayment
    {
        public void pay(string from, string to, double amount)
        {
            Console.WriteLine($"Credit Card {from} pad rs{amount} to {to} ");
        }
       public void sendReceipt(string to, double amount)
        {
            Console.WriteLine($"Sending eMail recipt to {to} for rs.{amount}");
        }
       public void logPay(string method, string status, DateTime time)
        {
            Console.WriteLine($"Log - {method} , status : {status} , Time : {time}");
        }
    }
    internal class interface_ex2
    {
        static void Main(string[] args)
        {
            Ipayment p1 = new CreditCardPayment();
            Console.WriteLine("-------");
            p1.pay("Dipali", "Lokesh", 25000);
            p1.sendReceipt("Dipali", 25000);
            p1.logPay("Credit Card", "Success", DateTime.Now);

            Console.ReadLine();

        }
    }
}

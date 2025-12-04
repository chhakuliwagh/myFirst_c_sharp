using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    class BankAccount
    {
        private string accountHolder;
        private string accountNumber;
        private double balance;

        public void CreateAccount()
        {
            Console.WriteLine("Enter Account Holder Name: ");
            accountHolder= Console.ReadLine();

            Console.WriteLine("Enter Account Number: ");
            accountNumber= Console.ReadLine();

            Console.WriteLine("Enter Opening balance: ");
            balance=Convert.ToDouble(Console.ReadLine());
        }

        public void Deposite()
        {
            Console.WriteLine("Enter Deposite Account: ");
            double amount=Convert.ToDouble(Console.ReadLine());

            if(amount < 0)
            {
                balance += amount;
                Console.WriteLine("Amount Depositi Succesefully: ");
            }
            else
            {
                Console.WriteLine("Invalid Deposite Amount: ");
            }
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter Withdraw Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount >0 && amount<balance)
            {
                balance -= amount;
                Console.WriteLine("Amount WithDraw succesfully");
            }
            else
            {
                Console.WriteLine("Insuffisient balane or Invalid Amount: ");
            }
        }
        public void showAccountInfo()
        {
            Console.WriteLine("--------Account Summary--------");
            Console.WriteLine("Account Holder Name: " +accountHolder);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account balance: " + balance);
        }
    }
    internal class EncapsulationEx2
    {
        static void Main(string[] args)
        {
            BankAccount b= new BankAccount();
            b.CreateAccount();
            b.Deposite();
            b.Withdraw();
            b.showAccountInfo();
            Console.ReadLine();
        }
    }
}

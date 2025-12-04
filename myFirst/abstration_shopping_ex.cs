using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class abstration_shopping_ex
    {
        class OrderPayment
        {
            public string customerName;
            private string productName;
            private double productPrice;
            private double tax = 0.08;
            private double processingFee = 25;
            private double totalPaybleAmount;

           public OrderPayment(string customerName, string productName, double productPrice)
            { 
                this.customerName = customerName;
                this.productName = productName;
                this.productPrice = productPrice;
               
            }

            private void ProcessPayment()
            {
                double taxAmount = productPrice * tax;
                totalPaybleAmount = productPrice + taxAmount + processingFee;

                Console.WriteLine($"Tax 8% : {taxAmount}");
                Console.WriteLine($"Processing Fee : {processingFee}");
                Console.WriteLine($"Total Amount : {totalPaybleAmount}");
            }
            public void placeOrder()
            {
                Console.WriteLine($"Customre name: {customerName}");
                Console.WriteLine($"Product name: {productName}");
                Console.WriteLine($"Product Prise: {productPrice}");
                this.ProcessPayment();
            }
        }
      
        static void Main(string[] args)
        {
            OrderPayment obj1 = new OrderPayment("Diapli","Perfume",850);
            obj1.placeOrder();
            Console.WriteLine("------------------------------------");
            OrderPayment obj2 = new OrderPayment("Apeksha", "Earings", 400);
            obj2.placeOrder();
        }
    }
}

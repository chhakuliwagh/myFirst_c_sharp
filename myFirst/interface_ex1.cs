using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    interface IPrinter
    {
        void Print(string document, int pages);
        void Scan(string document, string format);
    }
    class InkjetPrinter : IPrinter
    {
        public void Print(string document, int pages)
        {
            Console.WriteLine($"Inkjet Printing {pages} pages of {document}");
        }
        public void Scan(string document, string format)
        {
            Console.WriteLine($"Inkjet scanning {document} to {format} format..");
        }
    }

    class InkjetLasser : IPrinter
    {
        public void Print(string document, int pages)
        {
            Console.WriteLine($"Lasser Printing {pages} pages of {document}");
        }
        public void Scan(string document, string format)
        {
            Console.WriteLine($"Lasser scanning {document} to {format} format..");
        }
    }
    internal class interface_ex1
    {
        static void Main(string[] args)
        {
            IPrinter inkjet = new InkjetPrinter();

            Console.WriteLine("------------Inkjet  Printer------------");
            inkjet.Print("Report.pdf", 5);
            inkjet.Scan("AAdharCard.jpg", "abcd.pdf");

            IPrinter Lasser = new InkjetPrinter();
            Console.WriteLine();

            Console.WriteLine("------------ Inkjet  Lasser ------------");
            inkjet.Print("Report.pdf", 5);
            inkjet.Scan("AAdharCard.jpg", "abcd.pdf");


            Console.ReadLine();
        }
    }
}

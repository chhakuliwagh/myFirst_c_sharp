using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{
    internal class non_generic_hashtable_Ex1
    {
        static void DisplayProducts(Hashtable ht)
        {
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"ID : {item.Key} , Product Name: {item.Value}");

            }
        }
        static void Main(string[] args)
        {
            Hashtable products=new Hashtable();
            products.Add(101,"Laptop");
            products.Add(102,"Mobile");
            products.Add(103,"Tablet");
            Console.WriteLine("Initial Product List");
            DisplayProducts(products);
            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine($"\n Total Products: {products.Count}");
            Console.WriteLine($"\n Product With Id 102 : {products[102]} ");     //product[Key]
            Console.WriteLine("------------------------------------------------------------");

            products[102] = "Smart Phone";
             Console.WriteLine("Update Product with ID 102 ");
            Console.WriteLine($"\n Product With Id 102 : {products[102]} ");
            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine($"\n Total Products: {products.Count}");
            Console.WriteLine($"\n Product With Id 102 : {products[102]} ");
            products[103] = "TV";
            Console.WriteLine("Update Product with ID 103 ");
            Console.WriteLine($"\n Product With Id 1023: {products[103]} ");
            Console.WriteLine("------------------------------------------------------------");

            if (products.ContainsKey(104))
            {
                Console.WriteLine("Product Key exits");

            }
            else
            {
                Console.WriteLine("Product Key does Not exits..");
            }
            Console.WriteLine("------------------------------------------------------------");

            if (products.ContainsValue("Tablet"))
            {
                Console.WriteLine("Product name exits");

            }
            else
            {
                Console.WriteLine("Product name does Not exits..");
            }

            Console.WriteLine("------------------------------------------------------------");
            products.Remove(103);
            DisplayProducts(products);
            Console.WriteLine("------------------------------------------------------------");
            products.Clear();
            Console.WriteLine($"\n Total Products: {products.Count}");

            Console.ReadLine();
        }
    }
}

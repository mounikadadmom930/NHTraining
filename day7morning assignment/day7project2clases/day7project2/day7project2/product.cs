using System;
using System.Collections.Generic;

namespace Customer
{
    internal class product_1
    {

        public int product_ID;
        public string product_Name;
        public int product price;



        public void ReadProduct()
        {
            Console.WriteLine("Enter product_ID: ");
            product_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product_Name");
            product_Name = Console.ReadLine();

            Console.WriteLine("Enter product_price: ");
            roduct_price = convert.ToInt32(Console.ReadLine());
        }
        public void PrintProduct()
        {
            Console.WriteLine($"product_ID = {product_ID},product_Name = {product_Name}, product_price = {product_price}");

        }

        static void Main(string[] args)
        {
            product_1 product = new product_1();
            product.ReadProduct();
            product.PrintProduct();

            Console.ReadLine();
        }







    }
}

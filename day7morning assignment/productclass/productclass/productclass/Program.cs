using System;
using System.Collections.Generic;
//AUTHOR:PALURU MOUNIKA//
//PUPOSE:PRODUCT CLASS//

namespace Product
{
    internal class Product_1
    {

        public int Product_ID;
        public string Product_Name;
        public string Product_price;



        public void ReadProduct()
        {
            Console.WriteLine("Enter Product_ID: ");
            Product_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product_Name");
            Product_Name = Console.ReadLine();

            Console.WriteLine("Enter Product_price: ");
            Product_price = Console.ReadLine();
        }
        public void PrintProduct()
        {
            Console.WriteLine($"product_ID = {Product_ID},product_Name = {Product_Name}, product_price = {Product_price}");

        }

        static void Main(string[] args)
        {
            Product_1 Product = new Product_1();
            Product.ReadProduct();
            Product.PrintProduct();

            Console.ReadLine();
        }







    }
}


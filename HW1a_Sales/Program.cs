// HW1a Sales Total

// Your Name: Cooper Baer
// Did you seek help ? If yes, specify the helper or web link herehttps://www.w3schools.com/cs/index.php

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName;
            string quantityAsString;
            string PriceAsString;

            int quantity;
            double price;
            double subtotal;
            double SalesTax;
            double total;

            const double sales_tax_rate = 0.085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            productName = Console.ReadLine();

            Console.WriteLine("How many " + productName + "'s did you want to buy?");
            quantityAsString = Console.ReadLine();

            Console.WriteLine("What is the price for each " + productName + "?");
            PriceAsString = Console.ReadLine();

            quantity = Convert.ToInt32(quantityAsString);
            price = Convert.ToDouble(PriceAsString);

            subtotal = quantity * price;
            SalesTax = subtotal * sales_tax_rate;
            total = subtotal + SalesTax;

            Console.WriteLine("Your subtotal for your bill is " + subtotal.ToString("C2"));
            Console.WriteLine("Your sales tax for your bill is " + SalesTax.ToString("C2"));
            Console.WriteLine("Your total for your bill is " + total.ToString("C2"));

        }
    }
}

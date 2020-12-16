using System;
using System.Globalization;
using Exerc_Estoque.Entities;

namespace Exerc_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            Console.WriteLine("Enter product data: ");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Price: ");
            p1.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            p1.Quantity = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.Write("Enter the product number to be added to stock: ");
            int quantity = int.Parse(Console.ReadLine());
            p1.AddProduct(quantity);

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.Write("Enter the product number to be removed stock: ");
            quantity = int.Parse(Console.ReadLine());
            p1.RemoveProduct(quantity);

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

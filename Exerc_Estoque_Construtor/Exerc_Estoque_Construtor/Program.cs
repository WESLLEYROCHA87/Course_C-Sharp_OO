using System;
using System.Globalization;
using Exerc_Estoque_Construtor.Entities;

namespace Exerc_Estoque_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product("TV", 900.00, 10);
            
            Console.WriteLine(p.GetName());

            p.SetName("CARRO");

            Console.WriteLine(p.GetName());

            Console.ReadKey();
        }
    }
}

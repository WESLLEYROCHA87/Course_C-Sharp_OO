using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exerc_ContaBancaria.Entities;

namespace Exerc_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char s = char.Parse(Console.ReadLine());

            if (s == 's' || s == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depInical = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, nome, depInical);
            }
            else
            {
                c = new ContaBancaria(numero, nome);
            }
            
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

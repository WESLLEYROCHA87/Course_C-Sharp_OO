using System;
using System.Globalization;
using Exerc_SalarioFuncionario.Entities;

namespace Exerc_SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee f = new Employee();
            
            Console.Write("Name: ");
            f.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            f.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            f.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();

            Console.Write("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

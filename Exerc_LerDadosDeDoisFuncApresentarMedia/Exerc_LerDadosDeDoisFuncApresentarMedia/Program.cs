using System;
using System.Globalization;
using Exerc_LerDadosDeDoisFuncApresentarMedia.Entities;

namespace Exerc_LerDadosDeDoisFuncApresentarMedia
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            Employee f1, f2;

            f1 = new Employee();
            f2 = new Employee();

            Console.WriteLine("First employee data: ");
            Console.Write("Name: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Secont employee data: ");
            Console.Write("Name: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (f1.Salary + f2.Salary) / 2;

            Console.WriteLine("Salary average: " + average.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();

        }
    }
}

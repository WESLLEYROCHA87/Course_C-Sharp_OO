using System;
using System.Globalization;
using Exerc_SalarioFuncionario.Entities;

namespace Exerc_SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do
            funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada 
            (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. 

            Make a program to read an employee's data (name, gross salary and tax). Then show the data of the employee 
            (name and net salary). Then, increase the employee's salary based on a percentage given
            (only the gross salary is affected by the percentage) and show employee data again. 
            */

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

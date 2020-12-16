using System;
using System.Globalization;
using CalcLadoTrianguloMaior.Entities;

namespace CalcLadoTrianguloMaior
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

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.ReadKey();
        }
    }
}

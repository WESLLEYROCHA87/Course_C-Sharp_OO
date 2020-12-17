using System;
using System.Globalization;
using Exerc_MembrosEstáticos.Entities;

namespace Exerc_MembrosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // • Versão 3: classe Calculadora com método estático

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}

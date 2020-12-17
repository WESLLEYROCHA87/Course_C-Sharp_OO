using System;
using System.Globalization;
using Exerc_MembrosEstáticos.Entities;

namespace Exerc_MembrosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // • Versão 2: classe Calculadora com membros de instância

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }

    }
}

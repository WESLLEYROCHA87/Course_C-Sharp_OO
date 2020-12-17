using System;
using System.Globalization;

namespace Exerc_MembrosEstáticos
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {

            /*
             * Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera
             * para um raio daquele valor. Informar também o valor de PI com duas casas decimais. 
             
             * Versão 1: métodos na própria classe do programa 
             * • Nota: dentro de um método estático você não pode chamar membros de instância da mesma classe.              
             */

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferecia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));            
            
            Console.ReadKey();

        }

        static double Circunferecia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

    }
}

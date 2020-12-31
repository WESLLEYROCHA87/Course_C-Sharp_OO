using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modificador_params.Entities;

namespace Modificador_params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(5, 5, 5);

            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}

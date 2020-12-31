using System;
using Exerc_Vetor_CalcPrecoMedioProdutos.Entities;
using System.Globalization;

namespace Exerc_Vetor_CalcPrecoMedioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidades de produtos que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Entre com o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p[i] = new Produto { Nome = nome, Preco = preco };
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += p[i].Preco;
            }

            double media = sum / n;

            Console.Write("Preço Médio = : " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}

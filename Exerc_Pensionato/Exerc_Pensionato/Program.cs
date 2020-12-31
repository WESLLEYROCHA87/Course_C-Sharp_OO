using System;
using Exerc_Pensionato.Entities;

namespace Exerc_Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa que inicie com todos os dez quartos vazios, e depois
               leia uma quantidade N representando o número de estudantes que vão alugar quartos 
               (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. 
                Para cada registro de aluguel, informar o nome e email do estudante, bem como qual 
                dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. 
                Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, 
                por ordem de quarto, conforme exemplo.
            */

            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int qto = int.Parse(Console.ReadLine());
                vect[qto] = new Estudante { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            Console.ReadKey();
        }
    }
}

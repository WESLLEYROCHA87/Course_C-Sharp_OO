using System;
using Exerc_LerDadosInformarPessoaMaisVelha.Entities;

namespace Exerc_LerDadosInformarPessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            Person p1, p2;

            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("First person data: ");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Second person data: ");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine("Older person: " + p1.Name);
            }
            else
            {
                Console.WriteLine("Older person: " + p2.Name);
            }

            Console.ReadLine();

        }
    }
}

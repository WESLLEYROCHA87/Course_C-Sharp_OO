using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Add: adiciona ao final da lista;
            Console.WriteLine("Adiciona ao Final da Lista: ");
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Insert: insere onde você definir;
            Console.WriteLine("Insere onde for definido: ");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            // Count: mostra o tamanho da lista;
            Console.WriteLine("Mostra o tamanho da lista:");
            Console.WriteLine("Tamanho da lista: " + list.Count);
            Console.WriteLine();

            // Find: Encontra o primeiro elemento da lista que satisfaça um predicado:
            Console.WriteLine("Encontra o primeiro elemento: A");
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Find: " + s1);
            Console.WriteLine();

            // FindLast: Encontrar o último elemento da lista que satisfaça um predicado:
            Console.WriteLine("Encontra o último elemento: A");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("FindLast: " + s2);
            Console.WriteLine();

            // FindIndex: Encontrar primeira posição de elemento da lista que satisfaça um predicado:
            Console.WriteLine("Encontra a primeira POSIÇÃO: A");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("FindLastIndex A: " + pos1);
            Console.WriteLine();

            // FindLastIndex: Encontrar a última posição de elemento da lista que satisfaça um predicado:
            Console.WriteLine("Encontra a última POSIÇÃO: A");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("FindLastIndex A: " + pos2);
            Console.WriteLine();

            // FindAll: Filtrar a lista com base em um predicado:
            Console.WriteLine("Filtra por tamanho: 5");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine("Filtar todos com tamanho 5 caracteres: " + obj);
            }
            Console.WriteLine("---------------------------------------------------");

            // Remover elementos da lista:

            // RemoveAt:
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine("RemoveAt: Posição 2 " + obj);
            }
            Console.WriteLine("---------------------------------------------------");

            // Remove:
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine("Remove: Alex " + obj);
            }
            Console.WriteLine("---------------------------------------------------");

            // RemoveAll:
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine("Remove todos com inicial M: " + obj);
            }
            Console.WriteLine();

            // RemoveRange
            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine("RemoveRange: " + obj);
            }
            Console.WriteLine("---------------------------------------------------");

            Console.ReadKey();
        }
    }
}


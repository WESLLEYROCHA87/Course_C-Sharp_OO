using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exerc_CalcNotas.Entities;

namespace Exerc_CalcNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
             (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
             ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
             para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
             este problema. 
            
             Make a program to read a student's name and the three grades he obtained in the three quarters of the year
             (first quarter is worth 30 and the second and third are worth 35 each). At the end, show the student's final grade in the
             year. Also say whether the student is OK or FAILED and, if not, how many points are missing
             for the student to obtain the minimum to pass (which is 60 points). You must create a Student class to solve
             this problem.             
             */

            Student std = new Student();

            Console.Write("Student's name: ");
            std.Name = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades: ");
            std.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            std.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            std.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Note Final = " + std.FinalNote().ToString("F2", CultureInfo.InvariantCulture));

            if (std.Approved())
            {
                Console.WriteLine("APPROVED");
            }
            else
            {
                Console.WriteLine("DISAPPROVED");
                Console.WriteLine("MISSED " + std.RemainingNote().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

            Console.ReadKey();

        }
    }
}

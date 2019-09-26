using System;
using AulaPoo.Models;

namespace AulaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();
            
            Console.Clear();

            System.Console.WriteLine("Insira o Nome do Aluno");
            aluno1.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o Curso");
            aluno1.Curso = Console.ReadLine();

            System.Console.WriteLine("Insira o RG");
            aluno1.Rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira Idade");
            aluno1.Idade = int.Parse(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine($@"
            Nome:{aluno1.Nome} 
            Curso:{aluno1.Curso}
            RG:{aluno1.Rg}
            Idade:{aluno1.Idade}
            ");

        }
    }
}

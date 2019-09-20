using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nascimento;
            int atual;
            int dias;


            Console.WriteLine("Digite seu ano de nascimento:");
            nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            atual = int.Parse(Console.ReadLine());

            dias=(atual-nascimento)*365;
            
            int semana;

            semana= dias / 7;

            Console.WriteLine($"Você tem {semana} semanas vividos ");

            int idade;
            
            idade = (atual-nascimento);

            Console.WriteLine($"Você tem {idade} anos vividos ");




        }
    }
}

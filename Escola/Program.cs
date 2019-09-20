using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
  
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();


            Console.WriteLine("Digite suas 4 notas bimestrais");

            int n1;
            int n2;
            int n3;
            int n4;

            Console.WriteLine("Digite sua primeira nota:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota:");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua quarta nota:");
            n4 = int.Parse(Console.ReadLine());

            float media = (n1+n2+n3+n4);
            float final = media/4;
            
            Console.WriteLine($"{nome} {sobrenome} Sua media é de:{final}");

            if (final >=7)
            {
                Console.WriteLine($"{nome} {sobrenome} voce foi aprovado ");
            }

            else
            {
            Console.WriteLine($"{nome} {sobrenome} voce foi reprovado ");
            }
        }
    }
}
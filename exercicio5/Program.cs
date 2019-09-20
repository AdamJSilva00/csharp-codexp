using System;

namespace exercicio5
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
            string resultado;

            if(final>=7)
            {
            resultado = "Aprovado";
            }
            else{
                resultado = "Reprovado";
            }
            Console.WriteLine($"O Aluno {nome} com a media {final} esta {resultado}");
            



        }
    }
}

using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILe");
            string nome;

            do{
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            }
            while (nome.Length <=2);

            string senha;

            do{
            Console.WriteLine("Digite senha senha");
            senha = Console.ReadLine();
            }
            while (senha.Length <=8);
            
        }
    }
}

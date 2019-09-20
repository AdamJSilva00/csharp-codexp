using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Validação com DO WHILe");

            string email;

            do{
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            }
            while(!email.Contains("@") || !email.Contains(".com"));

        }
    }
}

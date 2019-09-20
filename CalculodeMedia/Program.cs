using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Aqui é onde iremos inserir o codigo //

            Console.WriteLine("Media final");

            int n1;
            int n2;
            int n3;
            
            Console.WriteLine("Digite a primeira nota");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira");
            n3 = int.Parse(Console.ReadLine());

            float resultado = (n1+n2+n3);

            float media = resultado /3;
            Console.WriteLine($"Sua Media é: {media}");

            
            









        }
    }
}

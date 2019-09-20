using System;

namespace Calculo_da_media
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("calculo de soma ");

            int n1;
            int n2;
        
            
            
            Console.WriteLine("Digite um numero ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            n2 = int.Parse(Console.ReadLine());

            

            int resultado = n1+n2;

            Console.WriteLine($"Seu resultado é: {resultado}");
        }
    }
}

using System;

namespace calculol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo media2");

            Console.WriteLine("Digite a primeira nota");
            int n1 = int.Parse(Console.ReadLine());
            
             Console.WriteLine("Digite a segunda nota");
            int n2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a terceira nota");
            int n3 = int.Parse(Console.ReadLine());

            float media = (n1+n2+n3);

            Console.WriteLine($"Sua media é de: {media/3}");



        }
    }
}

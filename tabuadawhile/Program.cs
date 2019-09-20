using System;

namespace tabuadawhile
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("tabuada");
        Console.Write("Digite o numero da tabuada que vc quer");
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine("!----------------------------------------------!");
        int i= 0;

        while (i <= 10)
        {
        Console.WriteLine($"{valor} X {i} = {valor*i}") ;
        
        i++;
        }

        }
    }
}

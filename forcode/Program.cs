using System;

namespace forcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("------------- Tabuada for -------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o numero da tabuada que vc quer.");
            
            float tabuada = float.Parse(Console.ReadLine());
            for(int contador = 0; contador <= 10 ; contador++){
                Console.WriteLine($"{tabuada} X {contador} = {tabuada*contador}");
            }
        }
    }
}

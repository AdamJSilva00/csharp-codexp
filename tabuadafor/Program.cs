using System;

namespace tabuadafor
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("tabuada");
        Console.Write("Digite o numero da tabuada que vc quer");
        int valor = int.Parse(Console.ReadLine());
        
        
        for (int i = 0; i < 11; i++)
        
            
        
        {
           Console.WriteLine($"{valor} X {i} = {valor*i}") ;
        }
        
         
       
        }
    }
}

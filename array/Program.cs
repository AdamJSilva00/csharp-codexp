using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While com Array");
            string [] nome = new string [3];
            int contador=0;
            
            while (contador<3)
            {  
            Console.WriteLine($"Digite o {contador+1}º nome");
            nome[contador] = Console.ReadLine();
            contador++;
            }

            contador=0;
            while (contador<3)
            {
                Console.WriteLine($"o nome na posição {contador} é {nome[contador]}");
                contador++;
            }


        }
    }
}

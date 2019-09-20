using System;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--!!  LAÇOS DE REPETIÇÂO  !!--");

            Console.WriteLine("Digite o numero inincial");
            int contador = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero em que deseja terminar");
            int limite = int.Parse(Console.ReadLine());
            
           
            while (contador <= limite)

            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }



        }
    }
}

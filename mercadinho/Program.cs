using System;

namespace mercadinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mercadinho do pedrin");
            
            string [] bebidas = new string [5];
           
            int contador = 0;

            while (contador<5)
            {
                Console.WriteLine($"qual  bebida vc deseja?");
            bebidas[contador] = Console.ReadLine();

            contador++;
            }

            contador = 0;
            while (contador<=5)
            {
            Console.WriteLine($"{contador+1} - {bebidas[contador]}");
            contador++;
            }
        }
    }
}

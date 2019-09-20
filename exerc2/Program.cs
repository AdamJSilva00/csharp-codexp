using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrir se seu numero e par ou impar");

            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0) 
            {
            Console.WriteLine("O número é par");
            }       
            else
            {          
            Console.WriteLine("O número é impar");
            }

            if (n2 % 2 == 0) 
            {
            Console.WriteLine("O número é par");
            }       
            else
            {          
            Console.WriteLine("O número é impar");
            }
           
            if (n1>n2)  
            {
            Console.WriteLine($"{n1} é maior que {n2}");
            }
            else
            {
               Console.WriteLine($"{n2} é maior que {n1}"); 
            }

        }
    }
}

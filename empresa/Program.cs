using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello trabalhador");

            float salario;

            Console.WriteLine("digite seu salario");
            salario = float.Parse(Console.ReadLine());

            if(salario < 990)
            {
            float aumento;
            aumento = (salario*30)/100;
            float final;
            final = aumento+salario;
            Console.WriteLine($"Voce tem direito a o salario, e vai ficar com R${final}");
            }
            else
            {
            Console.WriteLine("Voce não temm direito a aumento");
            }

            
        }
    }
}

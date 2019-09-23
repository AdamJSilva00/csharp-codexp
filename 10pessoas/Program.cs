using System;

namespace _10pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
        int idade;
        int maior= 0;
        int contador = 0;
        
        while (contador <10)
        {
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            contador++;

            if(idade >=18){
                maior++;
            }
            else
            {
    
            }
        }    

        Console.WriteLine($"{maior} maiores de idade");     
        }
    }
}


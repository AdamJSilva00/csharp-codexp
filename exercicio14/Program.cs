using System;

namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite sua idade nadador para vermos sua categoria");
            idade = int.Parse(Console.ReadLine());
            
            if(idade <= 7)
            {
            Console.WriteLine("Com essa idade de {idade} vc está na categoria (Infantil A) filho");
            }
            else if(idade <= 10)
            {
            Console.WriteLine("Com essa idade de {idade} vc está na categoria (Infantil B) filho");
            }
            else if(idade <= 13)
            {
            Console.WriteLine("Com essa idade de {idade} vc está na categoria (Juvenil A) filho");
            }
             else if(idade <= 17)
            {
            Console.WriteLine("Com essa idade de {idade} vc está na categoria (Juvenil B) filho");
            }
            else
            {
            Console.WriteLine("Com essa idade de {idade} vc está na categoria (Adulto)");
            }
  
        }
    }
}

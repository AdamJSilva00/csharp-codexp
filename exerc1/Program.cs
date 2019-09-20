using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu");
            Console.WriteLine("Digite seus numeros");

            Console.WriteLine("Digite  o pirmeiro numero");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite  o segundo numero");
            float n2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Qual opção deseja?");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("( 1 ) - Soma dos 2 numeros");
            Console.WriteLine("( 2 ) - Subtração do primeiro pelo segundo");
            Console.WriteLine("( 3 ) - Subtração do segundo pelo primeiro");
            Console.WriteLine("( 4 ) - Multiplicação dos dois numeros");
            Console.WriteLine("( 5 ) - Divisão do peimrio pelo segundo");
            Console.WriteLine("( 6 ) - Divisão do segundo pelo primeiro");
            Console.WriteLine("-------------");
            string resposta = Console.ReadLine();

            switch(resposta) {
            
                case "1":
                Console.WriteLine($"{n1+n2}");
                break;
                case "2":
                Console.WriteLine($"{n1-n2}");
                break;
                case "3":
                Console.WriteLine($"{n2-n1}");
                break;
                case "4":
                Console.WriteLine($"{n1*n2}");
                break;
                case "5":
                Console.WriteLine($"{n1/n2}");
                break;
                case "6":
                Console.WriteLine($"{n2/n1}");
                break;
            }
        }
    }
}

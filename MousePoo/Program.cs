using System;
using MousePoo.Models;


namespace MousePoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mousemouse1 rato1 = new Mousemouse1();

            Console.Clear();

            System.Console.WriteLine("Insira o Tamanho");
            rato1.Tamanho = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira a Marca");
            rato1.Marca = Console.ReadLine();

            System.Console.WriteLine("Insira o Botoes");
            rato1.Botoes = Console.ReadLine();

            System.Console.WriteLine("Insira o Material");
            rato1.Material = Console.ReadLine();

            System.Console.WriteLine("Insira o Modelo");
            rato1.Modelo = Console.ReadLine();


            Console.Clear();

            System.Console.WriteLine($@"
            Tamanho:{rato1.Tamanho} 
            Marca:{rato1.Marca}
            Botões:{rato1.Botoes}
            Material:{rato1.Material}
            Modelo:{rato1.Modelo}
            ");




        }
    }
}

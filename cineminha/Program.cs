using System;

namespace cineminha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cineminha");
            Console.WriteLine("Consulta de meia entrada");
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade<18||idade>=60){
                Console.WriteLine("vc tem direito a meia entrada");
            }
            else
            {
                Console.WriteLine("vc não tem direito a esse beneficio");
            }
        }
    }
}

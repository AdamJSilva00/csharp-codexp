using System;

namespace rodizioveicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio Veicular");
            Console.WriteLine("Digite o final da sua placa");
            int placa = int.Parse(Console.ReadLine());
            
            if(placa == 0 || placa == 1)
            {
            Console.WriteLine("Segunda Feira seu rodizio");
            }

            else if(placa == 2 || placa == 3)
            {
            Console.WriteLine("Terça feira seu rodizio");
            }

            else if(placa == 4 || placa == 5)
            {
            Console.WriteLine("quarta feira seu rodizio");
            }

             else if(placa == 6 || placa == 7)
            {
            Console.WriteLine("quinta feira seu rodizio");
            }

            else if (placa == 8 || placa == 9)
            
            {
            Console.WriteLine("sexta feira seu rodizio");
            }

            else{
                Console.WriteLine("placa não existente");
            }
        }
    }
}

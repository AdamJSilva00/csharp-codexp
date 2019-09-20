using System;

namespace rodizioveicular2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio Veicular");
            Console.WriteLine("Digite o final da sua placa");
            string placa = Console.ReadLine();
            int caracteres = placa.Length;
            int final = int.Parse(placa.Substring(caracteres -1));


            if(final == 0 || final == 1)
            {
            Console.WriteLine("Segunda Feira seu rodizio");
            }

            else if(final  == 2 || final  == 3)
            {
            Console.WriteLine("Terça feira seu rodizio");
            }

            else if(final  == 4 || final  == 5)
            {
            Console.WriteLine("quarta feira seu rodizio");
            }

             else if(final  == 6 || final  == 7)
            {
            Console.WriteLine("quinta feira seu rodizio");
            }

            else if (final  == 8 || final  == 9)
            
            {
            Console.WriteLine("sexta feira seu rodizio");
            }

            else{
                Console.WriteLine("placa não existente");
            }
        }
    }
}

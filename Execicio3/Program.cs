using System;

namespace Execicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int meses;
            int dias;
            int horas;
            int minutos;


            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            Console.WriteLine($"meses vividos : {meses}");

            dias = idade * 365;
            Console.WriteLine($"dias vividos: {dias}");

            horas = dias * 24;
            Console.WriteLine($"Horas vividos: {horas}");

            minutos = horas * 60;
            Console.WriteLine($"Minutos vividos : {minutos}");


        }
    }
}

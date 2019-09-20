using System;

namespace EE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de media e faltas");
            Console.WriteLine("!-------!");
            Console.WriteLine(" ");
            
            Console.WriteLine("Digite sua primeira nota");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas faltas");
            int faltas= int.Parse(Console.ReadLine());

            //Processamento

            double media = (n1+n2)/2;
            
            if(media >=50  && faltas<=30)
            {
//Resultado vdd
Console.WriteLine("Parabens se passou fi");
            }

else
{
//Resultado falso
    Console.WriteLine("Parabens vai estudar mais para passar ano que vem");
}

        }
    }
}

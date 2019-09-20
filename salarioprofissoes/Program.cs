using System;

namespace salarioprofissoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nunmero do cargo para descobrir o salrio");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("( 1 ) - Diretor");
            Console.WriteLine("( 2 ) - Gerente");
            Console.WriteLine("( 3 ) - Professor");
            Console.WriteLine("( 4 ) - Coordenador");
            Console.WriteLine("( 5 ) - Atendente");
            Console.WriteLine("-------------");
            string resposta = Console.ReadLine();

            switch(resposta) {
            
                case "1":
                Console.WriteLine("O salario do Diretir é de R$20.000,00");
                break;
                case "2":
                Console.WriteLine("O salario do Gerente é de R$14.000,00");
                break;
                case "3":
                Console.WriteLine("O salario do Professor é de R$10.000,00");
                break;
                case "4":
                Console.WriteLine("O salario do Coordenador é de R$7.000,00");
                break;
                case "5":
                Console.WriteLine("O salario do Atendente é de R$2.000,00");
                break;
                default:
                Console.WriteLine("Digite uma valor entre de 1 e 5");
                break;

                 }
            

        }
    }
}

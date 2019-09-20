using System;

namespace agenciadeturismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turismo");
            
            string[] nome = new string [2];
            string[] origem = new string [2];
            string[] destino = new string [2];
            DateTime[] data = new DateTime[2];

            int contador = 0;
            int opcao = 0;
            do
            {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Cadastrar Passagem");
            Console.WriteLine("2 - Listar passagem");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                Console.WriteLine("Vamos Cadatrar Agora");
                string  resposta = "";
                do{
                    if(contador < 2)
                    {
                    Console.WriteLine("Digite seu nome passageiro");
                    nome[contador] = Console.ReadLine();

                    Console.WriteLine("Digite a Origem");
                    origem[contador] = Console.ReadLine();

                    Console.WriteLine("Digite o Destino");
                    destino[contador] = Console.ReadLine();

                    Console.WriteLine("Digite a data do Vôo");
                    data[contador] =DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Você deseja cadastrar mais um vôo? S/N");
                    resposta = Console.ReadLine();
                    contador++;
                    }
                else
                {
                Console.WriteLine("Numero de passagem excedida");   
                }
                }while (resposta == "S");
                break;    
                
                case 2:
                Console.WriteLine("Listando Passagens");
                int contadorB = 0;
                while (contadorB < 2)
                {
                Console.WriteLine($"Passageiro nome: {nome[contadorB]}, origem: {origem[contadorB]}, destino: {destino[contadorB]}");
                contadorB++;
                }
                break;
                case 0:
                Console.WriteLine("Obrigado por usar nosso sistema");
                break;

                default:
                Console.WriteLine("Opção Invalida");
                break;
                }
                  
                }   
                while (opcao !=0);{
            }
        }    
    }
}
using System;

namespace cadastrofor
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Cadastro de Produto com for");

           string[] produtoNome = new string[3];
           double[] produtoPreco = new double[3];
           
            for(int i=0; i<3; i++)
                {
                Console.WriteLine($"Digite o nome do produto {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço:");
                produtoPreco[i] = double.Parse(Console.ReadLine());
                }//Fim do for
            foreach (var produto in produtoNome)
            {
                Console.WriteLine($"Produto:{produto}");
            }

            for(int i = 0; i < 3; i++){
                Console.WriteLine($"nome do produto:{produtoNome[i]}  preço{produtoPreco[i]}");
            }
           
        }
    }
}

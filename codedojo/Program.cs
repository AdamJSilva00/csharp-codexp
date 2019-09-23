using System;

namespace codedojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Dojo");

            string[] produto = new string[2];
            double[] preco = new double[2];

            int iterator= 0;
            bool continuar = true;
            int cod;

            while(continuar) {


                Console.WriteLine();
                Console.WriteLine();
            
                Console.WriteLine("--------------MENU--------------");
                Console.WriteLine("[1] Cadastrar produto");
                Console.WriteLine("[2] Listar produtos");
                Console.WriteLine("[3] Preço total dos produtos");
                Console.WriteLine("[0] Sair");
                Console.WriteLine();

                cod = int.Parse(Console.ReadLine());
               Console.Clear();
               

                switch (cod)
                {
                    case 0:
                        continuar = false;
                    break;

                    case 1:
                    var oi = true;
                        while (oi)
                        {
                            if (iterator < produto.Length )
                                {
                                Console.WriteLine("Digite o nome do seu produto");
                                produto[iterator] = Console.ReadLine();
                        
                                Console.WriteLine();

                                Console.WriteLine("Digite o preço do seu produto");
                                preco[iterator] =double.Parse( Console.ReadLine());
                                
                                     iterator++;

                                 Console.Clear();
                            
                                Console.WriteLine("Gostaria de cadastrar mais um produto(s/n)");
                                var a = Console.ReadLine();

                                if (a != "s")
                                {
                                    oi = false;
                                }
                                
                                Console.Clear();

                                }else
                                {
                                    Console.WriteLine("Limite excedido");
                                    Console.WriteLine("Aperte qualquer tecla para continuar");
                                    Console.ReadLine();
                                    break;
                                }
                            
                           
                        }
                            

                        Console.Clear();
                           
                    break;

                    case 2:
                    Console.WriteLine();

                   
                        int i = 0;
                      
                        while (i < iterator)
                        {
                            Console.WriteLine($"Nome do produto: {produto[i]}, Preço: R${preco[i]} reais");
                            Console.WriteLine();
                            i++;
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Precione qualquer tecla para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    break;

                  case 3:
                    
                    int o = 0;
                    double total = 0;
                    while (o < iterator)
                    {
                         total += preco[o];
                         o++;
                    }
                        Console.WriteLine($" Preço total em estoque é R${total} reais");
                        Console.WriteLine();
                        Console.WriteLine($"Precione qualquer tecla para continuar");
                        Console.ReadLine();
                        Console.Clear();
                  break;

                }
           
           
            };

        }
    }
}

using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite seu Salario");
            float salario =float.Parse(Console.ReadLine());
            Console.WriteLine("Qual é seu codigo?");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            string cargo;
            int porcentual;

            switch(codigo) {
            
                case 1:
                cargo = "Escrituario";
                porcentual = 50;
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Seu Salario {salario}");
                Console.WriteLine($"Seu codigo: {codigo}");
                Console.WriteLine($"Cargo:{cargo}");
                Console.WriteLine($"Porcentagem de aumento {porcentual}%");
                Console.WriteLine("novo salario: (salario*0.50)+salario");
                break;

                case 2:
                cargo = "Secretario";
                porcentual = 35;
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Seu Salario {salario}");
                Console.WriteLine($"Seu codigo: {codigo}");
                Console.WriteLine($"Cargo:{cargo}");
                Console.WriteLine($"Porcentagem de aumento {porcentual}%");
                Console.WriteLine("novo salario: (salario*0.35)+salario");
                break;

                case 3:
                  cargo = "Caixa";
                porcentual = 20;
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Seu Salario {salario}");
                Console.WriteLine($"Seu codigo: {codigo}");
                Console.WriteLine($"Cargo:{cargo}");
                Console.WriteLine($"Porcentagem de aumento {porcentual}%");
                Console.WriteLine("novo salario: (salario*0.20)+salario");
                break;

                case 4:
                  cargo = "Gerente";
                porcentual = 10;
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Seu Salario {salario}");
                Console.WriteLine($"Seu codigo: {codigo}");
                Console.WriteLine($"Cargo:{cargo}");
                Console.WriteLine($"Porcentagem de aumento {porcentual}%");
                Console.WriteLine("novo salario: (salario*0.10)+salario");
                break;

                case 5:
                  cargo = "Diretor";
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Seu Salario {salario}");
                Console.WriteLine($"Seu codigo: {codigo}");
                Console.WriteLine($"Cargo:{cargo}");
                Console.WriteLine("Não tem aumento");
                break;
                
            }
        }
    }
}

using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {   /*  efetuar cadastro do nome  de usuario com nome, telefone e  email*/
        /* dados de 5 usuarios */
           Console.WriteLine("Do While com Array");
            string [] nome = new string [5];
            string [] telefone = new string [5];
            string [] email = new string [5];
            int contador = 0;

            while (contador<5)
            {  
            Console.WriteLine($"Digite o {contador+1}º nome");
            nome[contador] = Console.ReadLine();

            Console.WriteLine($"Digite o {contador+1}º telefone");
            telefone[contador] = Console.ReadLine();

            Console.WriteLine($"Digite o {contador+1}º email");
            email[contador] = Console.ReadLine();

            contador++;
            }
            
            int contadorb=0;

                while (contadorb<5){
            Console.WriteLine($"O cliente numero {contadorb+1} - nome: { nome [contadorb]}, telefone: { telefone[contadorb]}e  email: { email [contadorb]}");
            contadorb++;
                }
           
        }
    }
}

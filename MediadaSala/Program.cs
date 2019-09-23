using System;

namespace MediadaSala
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] nota1 = new int[2];
                int[] nota2 = new int[2];
                double[] media = new double[2];
                int contador = 0;
                int reprovados = 0;
                int aprovados = 0;
                do 
                {
                        Console.WriteLine($"{contador+1}º aluno");

                        Console.WriteLine("Digite a primeira nota");
                        nota1[contador] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a segunda nota");
                        nota2[contador] = int.Parse(Console.ReadLine());

                        media[contador] = (nota1[contador] + nota2[contador])/2;
                    
                        if(media[contador] >= 7){
                            aprovados++;
                        }else{
                            reprovados++;
                        }

                        contador++;

            }while(contador < nota2.Length);

                        Console.Clear();
                        int contadorB = 0;
                        double somaMedia = 0;
                    
                    while(contadorB < 2){ 
                        somaMedia =+ media[contadorB];
                        contadorB++;
                        }
                        Console.WriteLine($"Media da sala é {somaMedia/2} temos {aprovados} Aprovados e {reprovados} Reprovados");                
        }
    }
}

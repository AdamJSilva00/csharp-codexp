using System;

namespace função {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Apredendo Função");

            Console.WriteLine ("Digite o primeiro numero");
            int numero1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o segundo numero");
            int numero2 = int.Parse (Console.ReadLine ());

            int resultadoDaSoma = SomaDeDoisNumeros (numero1, numero2);

            Console.WriteLine ($"O resultado da soma é {resultadoDaSoma}");

            int SomaDeDoisNumeros (int a, int b){
                int soma = a + b;
                return soma;
            }
        } //fim da main

        //Fim do main
        /// <summary>Efetua soma de dois numeros</summary>
        /// <param name="a">primeiro valor inteiro</param>
        /// <param name="b">segundo valor inteiro</param>
        /// <returns>Retorna a sima de dois numeros</returns>

        public static int SomaDeDoisNumeros (int a, int b) {
            int soma = a + b;
            return soma;

        }
        /// <summary> Retorna o texto de boas vindas </summary>

        public static string MensagemDeBoasVindas () {

            return "Bem Vindo ao Senai Informatica";
        }
    }
}
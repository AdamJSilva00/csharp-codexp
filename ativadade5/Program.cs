using System;

namespace ativadade5 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("atividade 5");

            string[] nome = new string[2];
            int[] idade = new int[2];
            double[] altura = new double[2];
            double[] peso = new double[2];
            double[] imc = new double[2];
            string[] sexo = new string[2];
            int somaM = 0;
            int somaF = 0;
            int idm = 0;
            int idf = 0;
            double finalm = 0;
            double finalf = 0;

            for (int i = 0; i < 2; i++) {
                Console.WriteLine ("Digite seu nome");
                nome[i] = Console.ReadLine ();

                Console.WriteLine ("Digite sua idade");
                idade[i] = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite sua altura");
                altura[i] = double.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite seu peso");
                peso[i] = double.Parse (Console.ReadLine ());

                imc[i] = peso[i] / (altura[i] * altura[i]);

                Console.WriteLine ("Digite a letra F (Feminino) e M (Masculino)");
                sexo[i] = Console.ReadLine ();

                if (sexo[i] == "M" || sexo[i] == "m") {
                    somaM = somaM + 1;
                    idm = idm + idade[i];
                } else {
                    somaF = somaF + 1;
                    idf = idf + idade[i];
                }

            }
            finalm = idm / somaM;

            finalf = idf / somaF;

            Console.WriteLine ($"Total de homems {somaM}");

            Console.WriteLine ($"Total de mulheres   {somaF}");

            Console.WriteLine ($"Media de idade dos homens.  {idm}");

            Console.WriteLine ($"Media de idade das mulheres.   {idf}");

            Console.WriteLine($"Nome:{nome}, sexo:{sexo}, imc:{imc} ");

        }
    }
}
using System;
using System.Globalization;

namespace ExerciciosProposto02 {
    class URI {
        static void Main(string[] args) {

            int n;

            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] valor = Console.ReadLine().Split(' ');

            //Alocando cada numero em uma casa do vetor
            for(int i = 0; i < n; i++) {
                vet[i] = int.Parse(valor[i]);
            }

            //Numeros Pares
            for(int i = 0; i < n; i++) {
                if(vet[i] % 2 == 0) {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.WriteLine();

            //Quantidade de Pares
            int quantidadePares = 0;
            for(int i = 0; i < n; i++) {
                if(vet[i] % 2 == 0) {
                    quantidadePares++;
                }
            }

            Console.WriteLine(quantidadePares);

        }
    }
}



using System;

namespace AnaliseDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]; // Array para armazenar os números
            int soma = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Digite 5 números inteiros:");

            // Loop para ler os números digitados pelo usuário e armazená-los no array
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                // Atualizar a soma
                soma += numeros[i];

                // Atualizar o maior número, se necessário
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                // Atualizar o menor número, se necessário
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            // Calcular a média
            double media = (double)soma / 5;

            // Exibir os resultados
            Console.WriteLine("\nResultados da análise:");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Menor número: {menor}");

            Console.ReadLine();
        }
    }
}

// Nome: Rodrigo Sergio Alves da Silva
// Lista 4 Atividade 3

using System;

public class Questao3
{
    // Procedimento para exibir os três valores em ordem crescente
    public void ExibirOrdemCrescente(int valorA, int valorB, int valorC)
    {
        int temp;

        // Ordenando os valores em ordem crescente usando o algoritmo Bubble Sort
        if (valorA > valorB)
        {
            temp = valorA;
            valorA = valorB;
            valorB = temp;
        }
        if (valorB > valorC)
        {
            temp = valorB;
            valorB = valorC;
            valorC = temp;
        }
        if (valorA > valorB)
        {
            temp = valorA;
            valorA = valorB;
            valorB = temp;
        }

        Console.WriteLine($"Valores em ordem crescente: {valorA}, {valorB}, {valorC}");
    }

    public void Rodar()
    {
        Console.Write("Digite o número de conjuntos de valores (N): ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nConjunto {i + 1}:");
            Console.Write("Digite o primeiro valor: ");
            int primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int segundoValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int terceiroValor = int.Parse(Console.ReadLine());

            ExibirOrdemCrescente(primeiroValor, segundoValor, terceiroValor);
        }
    }
}
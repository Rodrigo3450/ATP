// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 8

using System;

public class Program
{
    public static void Main()
    {
        Rodar();
    }

    public static void Rodar()
    {
        Console.WriteLine("\r\nEste programa preenche uma matriz 4x4 com números aleatórios entre 10 e 99.");
        Console.WriteLine("Em seguida, mostra na tela os elementos da diagonal principal e a soma dos elementos abaixo dela.\r\n");

        // Cria uma matriz 4x4
        int[,] mtz = new int[4, 4];

        // Obtém o tamanho da matriz
        int n = mtz.GetLength(0);

        // Preenche a matriz com números aleatórios
        PreencheVetor(ref mtz, n);

        // Mostra na tela os elementos da diagonal principal e abaixo dela
        MostraVetor(mtz, n);

        // Calcula e exibe a soma dos elementos abaixo da Diagonal Principal
        int soma = Soma(mtz, n);
        Console.WriteLine("A soma dos valores abaixo da Diagonal Principal é: " + soma);
    }

    // Procedimento para preencher a matriz com números aleatórios entre 10 e 99
    static void PreencheVetor(ref int[,] m, int n)
    {
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = r.Next(10, 100);
            }
        }
    }

    // Procedimento para mostrar na tela os elementos da diagonal principal e abaixo dela
    static void MostraVetor(int[,] m, int n)
    {
        Console.WriteLine("Matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= j)
                    Console.Write(m[i, j] + " ");
                else
                    Console.Write("   "); // Espaço em branco para elementos acima da diagonal principal
            }
            Console.WriteLine();
        }
    }

    // Função para calcular e retornar a soma dos elementos abaixo da diagonal principal
    static int Soma(int[,] m, int n)
    {
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j)
                    soma += m[i, j];
            }
        }
        return soma;
    }
}

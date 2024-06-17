// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 9


using System;

public class Program
{
    public static void Main()
    {
        Rodar();
    }

    public static void Rodar()
    {
        Console.WriteLine("\r\nEste programa preenche duas matrizes 4x6 com números aleatórios entre 10 e 35.");
        Console.WriteLine("Em seguida, calcula e exibe a soma e a diferença das duas matrizes,\r\n");

        // Declaração de variáveis e criação das matrizes A e B
        int linha = 4;
        int coluna = 6;
        int[,] a = new int[linha, coluna];
        int[,] b = new int[linha, coluna];

        // Preenche as matrizes A e B com valores aleatórios
        PreencheMatrizes(ref a, ref b, linha, coluna);

        // Exibe as matrizes A e B
        Console.WriteLine("Matriz A:");
        MostraMatriz(a, linha, coluna);
        Console.WriteLine();
        Console.WriteLine("Matriz B:");
        MostraMatriz(b, linha, coluna);

        // Calcula a matriz S (soma) e a matriz D (diferença)
        int[,] soma = SomaMatriz(a, b, linha, coluna);
        int[,] subtrai = SubtrairMatriz(a, b, linha, coluna);

        // Exibe as matrizes resultantes
        Console.WriteLine("\r\nResultado da soma das matrizes A e B:");
        MostraMatriz(soma, linha, coluna);
        Console.WriteLine("\r\nResultado da subtração das matrizes A e B:");
        MostraMatriz(subtrai, linha, coluna);
    }

    // Procedimento para preencher duas matrizes com números aleatórios entre 10 e 35
    static void PreencheMatrizes(ref int[,] m, ref int[,] mtz, int linha, int coluna)
    {
        Random r = new Random();
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                m[i, j] = r.Next(10, 36);
            }
        }

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                mtz[i, j] = r.Next(10, 36);
            }
        }
    }

    // Procedimento para mostrar na tela os elementos de uma matriz
    static void MostraMatriz(int[,] m, int linha, int coluna)
    {
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Função para calcular e retornar a matriz soma de duas matrizes
    static int[,] SomaMatriz(int[,] a, int[,] b, int linha, int coluna)
    {
        int[,] s = new int[linha, coluna];
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                s[i, j] = a[i, j] + b[i, j];
            }
        }
        return s;
    }

    // Função para calcular e retornar a matriz diferença de duas matrizes
    static int[,] SubtrairMatriz(int[,] a, int[,] b, int linha, int coluna)
    {
        int[,] s = new int[linha, coluna];
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                s[i, j] = a[i, j] - b[i, j];
            }
        }
        return s;
    }
}

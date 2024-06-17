// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 10

using System;

public class Program
{
    public static void Main()
    {
        Rodar();
    }

    // Procedimento principal que executa o programa
    public static void Rodar()
    {
        // Declaração da matriz 10x10
        int[,] mtz = new int[10, 10];
        int n = mtz.GetLength(0);

        // Preenche a matriz com números aleatórios entre 1 e 10
        PreencheMatriz(ref mtz, n);

        // Exibe a matriz original
        Console.WriteLine("Matriz Original:");
        MostrarMatriz(mtz, n);

        // Realiza as trocas especificadas
        TrocaLinhas(ref mtz, n);
        Console.WriteLine("\r\nMatriz após trocar linha 2 com linha 8:");
        MostrarMatriz(mtz, n);

        TrocaColunas(ref mtz, n);
        Console.WriteLine("\r\nMatriz após trocar coluna 4 com coluna 10:");
        MostrarMatriz(mtz, n);

        TrocaDiagonais(ref mtz, n);
        Console.WriteLine("\r\nMatriz após trocar diagonal principal com diagonal secundária:");
        MostrarMatriz(mtz, n);

        TrocaColRow(ref mtz, n);
        Console.WriteLine("\r\nMatriz após trocar linha 5 com coluna 10:");
        MostrarMatriz(mtz, n);
    }

    // Preenche a matriz com números aleatórios entre 1 e 10
    static void PreencheMatriz(ref int[,] m, int n)
    {
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = r.Next(1, 10);
            }
        }
    }

    // Exibe a matriz
    static void MostrarMatriz(int[,] m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Troca a linha 2 com a linha 8
    static void TrocaLinhas(ref int[,] m, int n)
    {
        for (int j = 0; j < n; j++)
        {
            int aux = m[1, j];
            m[1, j] = m[7, j];
            m[7, j] = aux;
        }
    }

    // Troca a coluna 4 com a coluna 10
    static void TrocaColunas(ref int[,] m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int aux = m[i, 3];
            m[i, 3] = m[i, 9];
            m[i, 9] = aux;
        }
    }

    // Troca a diagonal principal com a diagonal secundária
    static void TrocaDiagonais(ref int[,] m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int aux = m[i, i];
            m[i, i] = m[i, (n - i - 1)];
            m[i, (n - i - 1)] = aux;
        }
    }

    // Troca a linha 5 com a coluna 10
    static void TrocaColRow(ref int[,] m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int aux = m[4, i];
            m[4, i] = m[i, 9];
            m[i, 9] = aux;
        }
    }
}

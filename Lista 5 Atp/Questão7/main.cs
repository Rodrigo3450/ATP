// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 7

using System;

public class Program
{
    public static void Main()
    {
        Rodar();
    }

    // Procedimento principal
    public static void Rodar()
    {
        Console.WriteLine("\r\nEste programa preenche uma matriz 5x5 com números aleatórios entre 1 e 10.");
        Console.WriteLine("Em seguida, calcula e exibe as seguintes somas da matriz:");
        Console.WriteLine("a) A soma dos elementos da linha 4.");
        Console.WriteLine("b) A soma dos elementos da coluna 2.");
        Console.WriteLine("c) A soma dos elementos da diagonal principal.");
        Console.WriteLine("d) A soma dos elementos da diagonal secundária.");
        Console.WriteLine("e) A soma de todos os elementos da matriz.\r\n");

        // Cria uma matriz 5x5 e a preenche com valores aleatórios
        int[,] m = new int[5, 5];
        m = CriaMatriz(m);

        // Exibe a matriz gerada
        MostrarMatriz(m);

        // Calcula as somas conforme especificado no exercício
        int somaR4 = SomaRow4(m);
        int somaC2 = SomaCol2(m);
        int dp = SomaDP(m);
        int ds = SomaDS(m);
        int somaMatriz = SomaMatriz(m);

        // Exibe as somas calculadas
        Console.WriteLine("\r\n Somas da Matriz: \r\nA soma da Linha 4 é: {0}\r\nA soma da Coluna 2 é: {1}\r\nA soma da Diagonal Principal é: {2}\r\nA soma da Diagonal Secundária é: {3}\r\nA soma de todos os elementos da matriz é: {4}", somaR4, somaC2, dp, ds, somaMatriz);
    }

    // Função para criar e preencher a matriz com números aleatórios de 1 a 10
    public static int[,] CriaMatriz(int[,] mtz)
    {
        int n = mtz.GetLength(0);
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mtz[i, j] = r.Next(1, 10);
            }
        }
        return mtz;
    }

    // Procedimento para exibir a matriz
    static void MostrarMatriz(int[,] m)
    {
        Console.WriteLine("Matriz:");
        int n = m.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Função para calcular a soma da linha 4
    static int SomaRow4(int[,] m)
    {
        int n = m.GetLength(0);
        int soma = 0;
        int linha = 3;
        for (int j = 0; j < n; j++)
        {
            soma += m[linha, j];
        }
        return soma;
    }

    // Função para calcular a soma da coluna 2
    static int SomaCol2(int[,] m)
    {
        int n = m.GetLength(0);
        int soma = 0;
        int col = 1;
        for (int i = 0; i < n; i++)
        {
            soma += m[i, col];
        }
        return soma;
    }

    // Função para calcular a soma da diagonal principal
    static int SomaDP(int[,] m)
    {
        int n = m.GetLength(0);
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += m[i, i];
        }
        return soma;
    }

    // Função para calcular a soma da diagonal secundária
    static int SomaDS(int[,] m)
    {
        int n = m.GetLength(0);
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += m[i, (n - i - 1)];
        }
        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaMatriz(int[,] m)
    {
        int n = m.GetLength(0);
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                soma += m[i, j];
            }
        }
        return soma;
    }
}

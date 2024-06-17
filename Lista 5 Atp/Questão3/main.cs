// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 3

using System;

class Program
{
    static void Main()
    {
        Exercicio3();
    }

    public static void Exercicio3()
    {
        Console.Clear();
        int[] x = new int[10];
        int n = 0;

        Vetor03(x, ref n);
        Console.WriteLine($"Números negativos em X: {n}");

        int[] y = CopiaVetor(x, n);

        Console.WriteLine("Vetor original X:");
        ExibirVetor(x);

        Console.WriteLine("Vetor de valores negativos Y:");
        ExibirVetor(y);

        Console.ReadKey();
        Console.Clear();
    }

    public static void Vetor03(int[] x, ref int n)
    {
        Random rnd = new Random();
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = rnd.Next(-50, 51);
            if (x[i] < 0)
            {
                n++;
            }
            Console.WriteLine($"X[{i}] = {x[i]}");
        }
    }

    static int[] CopiaVetor(int[] x, int n)
    {
        int[] y = new int[n];
        int p = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < 0)
            {
                y[p] = x[i];
                Console.WriteLine($"Y[{p}] = {y[p]}");
                p++;
            }
        }
        return y;
    }

    static void ExibirVetor(int[] vetor)
    {
        foreach (int valor in vetor)
        {
            Console.WriteLine(valor);
        }
    }
}

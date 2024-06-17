// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 4

using System;

class Program
{
    static void Main()
    {
        Exercicio4();
    }

    public static void Exercicio4()
    {
        Console.Clear();
        int[] x = new int[10];
        int[] y = new int[10];
        Preenchimento04(x, y);

        int[] z = NovoVetor04(x, y);

        Console.WriteLine("Vetor X:");
        ExibirVetor(x);

        Console.WriteLine("Vetor Y:");
        ExibirVetor(y);

        Console.WriteLine("Vetor Z (intercalado):");
        ExibirVetor(z);

        Console.ReadKey();
        Console.Clear();
    }

    public static void Preenchimento04(int[] x, int[] y)
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            x[i] = rnd.Next(0, 11);
            y[i] = rnd.Next(0, 11);
            Console.WriteLine($"X[{i}] = {x[i]} \t Y[{i}] = {y[i]}");
        }
    }

    public static int[] NovoVetor04(int[] x, int[] y)
    {
        int[] z = new int[20];
        int index = 0;

        for (int i = 0; i < 10; i++)
        {
            z[index] = y[i];  // posição par
            index++;
            z[index] = x[i];  // posição ímpar
            index++;
        }

        return z;
    }

    public static void ExibirVetor(int[] vetor)
    {
        foreach (int valor in vetor)
        {
            Console.WriteLine(valor);
        }
    }
}

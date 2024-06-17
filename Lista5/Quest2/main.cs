// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 2

using System;

class Program
{
    static void Main()
    {
        int[] notas = new int[10];
        PreencherNotas(notas);
        CalculaMediaEContaAcimaDaMedia(notas);
    }
    // Procedimento para preencher o vetor com as notas
    static void PreencherNotas(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite a nota do aluno " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    // Procedimento para calcular a média e contar os alunos acima da média.
    static void CalculaMediaEContaAcimaDaMedia(int[] vetor)
    {
        int soma = 0;
        int acimaDaMedia = 0;
        double media;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        media = (double)soma / vetor.Length;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > media)
            {
                acimaDaMedia++;
            }
        }
        Console.WriteLine("A média da turma e: " + media);
        Console.WriteLine("Alunos com notas acima da média: " + acimaDaMedia);
    }
}

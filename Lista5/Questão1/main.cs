// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 1

using System;

class Program
{
    static void Main()
    {
        int[] N = new int[20];
        LerVetor(N);

        int posicaoMenorElemento = EncontrarPosicaoMenorElemento(N);
        ExibirMenorElementoEnaPosicao(N, posicaoMenorElemento);
    }
    //Função para ler os elementos do vetor
    static void LerVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite o elemento N[" + i + "]");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    // Função para encontrar a posição do menor elemento do vetor
    static int EncontrarPosicaoMenorElemento(int[] vetor)
    {
        int menorElemento = vetor[0];
        int posicaoMenorElemento = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicaoMenorElemento = i;
            }
        }
        return posicaoMenorElemento;
    }
    // Função para exibir o menor elemento e sua posição no vetor.
    static void ExibirMenorElementoEnaPosicao(int[] vetor, int posicao)
    {
        int menorElemento = vetor[posicao];
        Console.WriteLine("O menor elemento de N é " + menorElemento + " e sua posição dentro do vetor é: " + posicao);
    }
}
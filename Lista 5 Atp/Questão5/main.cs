// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 5
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
        // Mensagem inicial
        Console.WriteLine("Este programa sorteia 3 números inteiros (entre 10 e 50) e coloca dentro de um vetor. A tarefa do usuário é tentar adivinhar um dos 3 números que foram sorteados. No final o programa imprime o número de tentativas e quais valores foram sorteados.\r\n");

        // Chama a função SorteiaVetor para obter os números sorteados
        int[] vetorSorteado = SorteiaVetor();

        // Inicializa a variável para contar as tentativas
        int qtdTentativas = 0;

        // Chama o procedimento DescobreVetor para que o usuário tente adivinhar os números
        DescobreVetor(vetorSorteado, ref qtdTentativas);

        // Exibe a mensagem de acerto, o número de tentativas e os números sorteados
        Console.WriteLine("\r\nAcertou!\r\nTentativas: " + qtdTentativas);
        Console.WriteLine("\r\nNúmeros sorteados:");
        foreach (int numero in vetorSorteado)
        {
            Console.Write(numero + " ");
        }
    }

    // Função para sortear 3 números aleatórios entre 10 e 50 e colocar em um vetor
    static int[] SorteiaVetor()
    {
        int[] numerosSorteados = new int[3];
        Random random = new Random();
        for (int i = 0; i < numerosSorteados.Length; i++)
        {
            int numeroSorteado = random.Next(10, 51);

            // Verifica se o número sorteado é igual ao anterior no vetor
            if (i > 0 && numeroSorteado == numerosSorteados[i - 1])
                i--; // Se igual, sorteia novamente
            else
                numerosSorteados[i] = numeroSorteado;
        }

        return numerosSorteados;
    }

    // Procedimento para permitir que o usuário tente adivinhar os números sorteados
    static void DescobreVetor(int[] vetor, ref int count)
    {
        int palpite, acerto = 0;
        do
        {
            Console.WriteLine("\r\nDigite um número inteiro entre 10 e 50: ");
            palpite = Convert.ToInt32(Console.ReadLine());

            // Verifica se o palpite do usuário está entre os números sorteados
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == palpite)
                {
                    acerto = vetor[i];
                }
            }

            // Incrementa o número de tentativas
            count++;

            // Exibe mensagem de erro se o palpite estiver incorreto
            if (palpite != acerto)
                Console.WriteLine("Errado! Tente novamente.");

        } while (palpite != acerto); // Continua o loop até o usuário acertar
    }
}


// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 2

using System;

public class Program
{   
    // Procedimento principal
    public static void Main()
    {
        Rodar();
    }

    // Outros procedimentos aqui...

    //Procedimento principal
    public static void Rodar()
    {
        // Mensagem inicial
        Console.WriteLine("Esse programa faz a leitura das notas de 10 alunos, imprime a média da turma e quantos alunos obtiveram nota acima dessa média.");

        // Declarando o vetor de notas e a variável de média
        double[] notas = new double[10];
        double media = 0;

        // Chama o procedimento para preencher o vetor e calcular a média
        VetorEMedia(ref notas, ref media);

        // Pulando linha
        Console.WriteLine();

        // Chama o procedimento para mostrar os resultados
        Resultado(notas, media);
    }

    // Procedimento para preencher o vetor e calcular a média
    static void VetorEMedia(ref double[] v, ref double media)
    {
        // Loop para preencher o vetor
        for (int i = 0; i < v.Length; i++)
        {
            // Solicita ao usuário para digitar a nota do aluno
            Console.WriteLine("\r\nDigite a nota do aluno nº{0}: ", i + 1);

            // Lê a entrada do usuário e converte para double
            double nota = double.Parse(Console.ReadLine());

            // Verifica se a nota é válida
            if (nota < 0)
            {
                // Se a nota for inválida, mostra uma mensagem e decrementa o índice para que o usuário insira outro valor
                Console.WriteLine("\r\nValor de nota inválido. Insira outro valor.");
                i--;
            }
            else
            {
                // Se a nota for válida, armazena no vetor e adiciona à média
                v[i] = nota;
                media += v[i];
            }

            // Limpa a tela
            Console.Clear();
        }

        // Calcula a média
        media /= v.Length;
    }

    // Procedimento para mostrar os resultados
    static void Resultado(double[] notas, double media)
    {
        // Contador para o número de alunos com nota acima da média
        int acimaMedia = 0;

        // Loop para verificar as notas e contar os alunos com nota acima da média
        for (int i = 0; i < notas.Length; i++)
        {
            // Se a nota for maior que a média, incrementa o contador e mostra a nota do aluno
            if (notas[i] > media)
            {
                acimaMedia++;
                Console.WriteLine("O aluno de nº{0} com nota {1} ficou acima da média", i + 1, notas[i]);
            }
        }

        // Mostra a média da turma e o número de alunos acima da média
        Console.WriteLine("\r\nA média é: {0}\r\nO número de alunos acima da média é: {1} ", media, acimaMedia);
    }
}


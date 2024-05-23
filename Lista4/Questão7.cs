// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 7

using System;

public class Questao7
{
    // Procedimento que recebe a média final e exibe o conceito
    public void MostrarConceito(double mediaAluno)
    {
        if (mediaAluno <= 39)
        {
            Console.WriteLine("Conceito F");
        }
        else if (mediaAluno <= 59)
        {
            Console.WriteLine("Conceito E");
        }
        else if (mediaAluno <= 69)
        {
            Console.WriteLine("Conceito D");
        }
        else if (mediaAluno <= 79)
        {
            Console.WriteLine("Conceito C");
        }
        else if (mediaAluno <= 89)
        {
            Console.WriteLine("Conceito B");
        }
        else
        {
            Console.WriteLine("Conceito A");
        }
    }

    public void Rodar()
    {
        // Solicita ao usuário a quantidade de alunos
        Console.Write("Digite o número de alunos: ");
        int numeroAlunos = int.Parse(Console.ReadLine());

        // Loop para ler a média de cada aluno e acionar o procedimento
        for (int i = 1; i <= numeroAlunos; i++)
        {
            Console.Write("Digite a média final do aluno {i}: ");
            double mediaAluno = double.Parse(Console.ReadLine());

            // Chama o procedimento para exibir o conceito do aluno
            Console.Write($"O aluno {i} tem ");
            MostrarConceito(mediaAluno);
        }
    }
}
// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 questão 9

using System;

public class Questao9
{
    public void Rodar()
    {
        // Declaração da variável para armazenar o número de alunos
        int numeroAlunos;

        // Solicita ao usuário que digite o número de alunos
        Console.WriteLine("Digite o número de alunos: ");

        // Lê o número de alunos fornecido pelo usuário e converte para inteiro
        numeroAlunos = int.Parse(Console.ReadLine());

        // Chama a função Calculo para calcular a média das notas dos alunos aprovados
        double resultado = Calculo(numeroAlunos);

        // Verifica se há alunos aprovados (resultado diferente de -1)
        if (resultado != -1)
        {
            // Imprime a média das notas dos alunos aprovados
            Console.WriteLine("A média das notas dos alunos aprovados é: " + resultado);
        }
        else
        {
            // Caso nenhum aluno seja aprovado, imprime uma mensagem informando isso
            Console.WriteLine("Nenhum aluno foi aprovado!");
        }
    }

    // Função para calcular a média das notas dos alunos aprovados
    public double Calculo(int numAlunos)
    {
        // Declaração das variáveis
        double nota, media = 0, soma = 0, contador = 0;

        // Loop para iterar sobre o número de alunos informado
        for (int i = 0; i < numAlunos; i++)
        {
            // Solicita ao usuário que digite a nota do aluno atual
            Console.WriteLine("Digite a nota do aluno " + (i + 1) + ": ");

            // Lê a nota fornecida pelo usuário e converte para double
            nota = double.Parse(Console.ReadLine());

            // Verifica se a nota é maior ou igual a 6 (nota de aprovação)
            if (nota >= 6)
            {
                // Incrementa o contador de alunos aprovados
                contador++;

                // Adiciona a nota à soma total das notas dos alunos aprovados
                soma += nota;
            }
        }

        // Verifica se pelo menos um aluno foi aprovado
        if (contador >= 1)
        {
            // Calcula a média das notas dos alunos aprovados
            media = soma / contador;
            return media;
        }
        else
        {
            // Retorna -1 se nenhum aluno for aprovado
            return -1;
        }
    }
}


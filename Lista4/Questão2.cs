// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 2

using System;

public class Questao2
{
    // Procedimento para calcular e exibir a média de salário da população
    public void CalcularMediaSalario()
    {
        double totalSalario = 0;
        int totalPessoas = 0;

        Console.Write("Digite o número de habitantes: ");
        int numeroHabitantes = int.Parse(Console.ReadLine());

        if (numeroHabitantes <= 0)
        {
            Console.WriteLine("Número de habitantes inválidos.");
            return;
        }

        Console.WriteLine($"Digite o salário de cada um dos {numeroHabitantes} habitantes:");

        while (totalPessoas < numeroHabitantes)
        {
            Console.Write($"Salário do habitante {totalPessoas + 1}: ");
            double salario = double.Parse(Console.ReadLine());

            totalSalario += salario;
            totalPessoas++;
        }

        double mediaSalario = totalSalario / numeroHabitantes;
        Console.WriteLine($"Média salarial da população: {mediaSalario}");
    }

    public void Rodar()
    {
        CalcularMediaSalario();
    }
}
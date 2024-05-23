//Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 8

using System;

public class Questao8
{
    // Função para calcular o valor de S na fórmula fornecida
    public static double CalcularS(int valorN)
    {
        double soma = 0;
        for (int i = 2; i <= valorN; i++)
        {
            double numerador = i * i + 1;
            double denominador = i + 3;
            soma += numerador / denominador;
        }
        return soma;
    }

    public void Rodar()
    {
        // Solicita ao usuário o valor de N
        Console.Write("Digite o valor de N (inteiro e positivo): ");
        int valorN = int.Parse(Console.ReadLine());

        // Chama a função para calcular o valor de S e exibe o resultado
        double resultadoS = CalcularS(valorN);
        Console.WriteLine($"O valor de S é: {resultadoS}");
    }
}
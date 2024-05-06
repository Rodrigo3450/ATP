// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 7

using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa a variável soma com zero
        double soma = 0;
        // Declaração das variáveis n e contador, sendo n o número fornecido pelo usuário e contador para iterar sobre os termos da série
        int n, contador = 1;

        // Mensagem inicial do programa.
        Console.WriteLine("Este é um programa que calcula a soma:");

        // Solicita ao usuário que insira um número inteiro e positivo e armazena na variável n
        Console.WriteLine("Digite um número inteiro e positivo:");
        n = int.Parse(Console.ReadLine());

        // Verifica se n é um número positivo
        if (n <= 0)
        {
            // Se não for, exibe mensagem de número inválido
            Console.WriteLine("Número inválido! O número deve ser inteiro e positivo.");
        }
        else
        {
            // Início do loop para calcular a soma dos termos da série até o número n
            while (contador <= n)
            {
                // Cálculo do termo da série e adição à variável soma
                soma += 1.0 / contador;
                // Exibe o termo gerado
                Console.WriteLine("Termo {0}: 1/{1}", contador, contador);
                // Incrementa o contador para avançar para o próximo termo da série
                contador++;
            }

            // Exibe a soma total da série
            Console.WriteLine("A soma total é de: " + soma);
        }
    }
}

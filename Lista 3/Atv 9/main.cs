// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 9

using System;

class Program
{
    static void Main(string[] args)
    {
        int elemento, primeiro = 0, segundo = 1, soma = 0;

        // Solicita ao usuário que insira o valor limite L
        Console.WriteLine("Digite o valor limite L para a soma dos elementos da série de Fibonacci:");
        elemento = int.Parse(Console.ReadLine());

        // Loop para gerar os elementos da série de Fibonacci e calcular a soma
        while (segundo < elemento)
        {
            // Verifica se o segundo número é menor que L e adiciona-o à soma
            if (segundo < elemento)
            {
                soma += segundo;
            }

            // Calcula o próximo número da série de Fibonacci
            int proximo = primeiro + segundo;

            // Atualiza os valores dos dois últimos elementos da série de Fibonacci
            primeiro = segundo;
            segundo = proximo;
        }

        // Exibe a soma dos elementos da série de Fibonacci menores que L
        Console.WriteLine("A soma dos elementos da série de Fibonacci menores que " + elemento + " é: " + soma);
    }
}

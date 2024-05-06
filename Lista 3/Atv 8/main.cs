// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atvidade 8

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variaveis com os primeiros dois elementos da série.
        int elemento, primeiro = 0, segundo = 1, proximoNum;

        // Solicita ao usuário que insira o número de elementos 
        Console.WriteLine("Digite o número de elementos da série de Fibonacci a serem exibidos:");
        elemento = int.Parse(Console.ReadLine());

        // Exibe os primeiros elementos da série + os dois primeiros elementos
        Console.WriteLine("Os primeiros " + elemento + " elementos da série de Fibonacci são:");
        Console.Write(primeiro + ", " + segundo);

        // Loop para gerar e exibir os próximos elementos da série
        for (int i = 2; i < elemento; i++)
        {
            // Calcula e exibe o próximo número da série
            proximoNum = primeiro + segundo;
            Console.Write(", " + proximoNum);

            // Atualiza o primeiro número para o segundo e o segundo número para o próximo
            primeiro = segundo;
            segundo = proximoNum;
        }

        Console.WriteLine(); // Adiciona uma quebra de linha no final
    }
}
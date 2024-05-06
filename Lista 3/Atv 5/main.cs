// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atv 5

using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa E com 1, pois o primeiro termo é sempre 1
        // Inicializa o fatorial com 1, pois 0! e 1!
        int numero;
        double E = 1, fatorial = 1;

        // Solicita ao usuário que insira um número inteiro e positivo 
        Console.WriteLine("Digite um número inteiro e positivo:");
        numero = int.Parse(Console.ReadLine());

        // Loop para calcular e adicionar os termos adicionais da série
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i; // Calcula o fatorial de i
            E += 1.0 / fatorial; // Adiciona o inverso do fatorial à soma E
        }

        // Imprime o valor na tela.
        Console.WriteLine("O valor de E é: " + E);
    }
}
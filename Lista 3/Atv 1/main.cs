// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 1

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis.
        int digito, numeros, positivo = 0, negativo = 0, zero = 0;

        // Comando para o usuário determinar a quantidade de números que vai digitar.
        Console.WriteLine("Quantos números você deseja digitar? ");
        digito = int.Parse(Console.ReadLine());

        // Loop para os números do usuário.
        for (int i = 0; i < digito; i++)
        {
            // Comando para o usuário digitar os números.
            Console.WriteLine("Digite números inteiros: ");
            numeros = int.Parse(Console.ReadLine());

            // Condição para separar os positivos, negativos e zeros.
            if (numeros > 0)
            {
                positivo++;
            }
            else if (numeros < 0)
            {
                negativo++;
            }
            else
            {
                zero++;
            }
        }

        // Imprimir os resultados na tela.
        Console.WriteLine("Números positivos: " + positivo);
        Console.WriteLine("Números negativos: " + negativo);
        Console.WriteLine("Zeros: " + zero);
    }
}

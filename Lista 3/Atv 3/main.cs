// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atv 3

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis.
        int numeros, quantidadetresnove = 0, quantidadedois = 0, quantidadecinco = 0;

        // Comando de título do programa.
        Console.WriteLine("Digite 10 números:");

        // Looping para os dígitos.
        for (int contador = 0; contador < 10; contador++)
        {
            // Comando para o usuário digitar os números.
            Console.WriteLine("Digite um número:");
            numeros = int.Parse(Console.ReadLine());

            // Verificações de divisibilidade.
            if (numeros % 3 == 0 && numeros % 9 == 0)
            {
                quantidadetresnove++;
            }
            else if (numeros % 2 == 0 && numeros % 5 == 0)
            {
                quantidadedois++;
            }
            else if (numeros % 5 == 0)
            {
                quantidadecinco++;
            }
            else
            {
                // Caso não seja divisível, exibe a mensagem.
                Console.WriteLine("Número não é divisível pelos valores");
            }
        }

        // Imprimindo valores na tela.
        Console.WriteLine("A quantidade de divisíveis por 3 e por 9 ao mesmo tempo é: {0}", quantidadetresnove);
        Console.WriteLine("A quantidade de divisíveis por 2 e por 5 é: {0}", quantidadedois);
        Console.WriteLine("A quantidade de divisíveis por 5 é: {0}", quantidadecinco);
    }
}

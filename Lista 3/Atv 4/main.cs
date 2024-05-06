// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 4

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        int numero, fatorial = 1;

        // Comando de título do programa
        Console.WriteLine("Digite um número para o cálculo do fatorial:");

        // Comando para que o usuário digite um número para que seja realizada a fatoração dele.
        Console.WriteLine("Digite um número:");
        numero = int.Parse(Console.ReadLine());

        // Condição para que seja realizada a fatoração de um número
        if (numero >= 0)
        {
            for (int i = 1; i <= numero; i++)
            {
                // Cálculo do fatorial.
                fatorial *= i;
            }

            // Impressão do resultado na tela.
            Console.WriteLine("O fatorial de {0} é igual a: {1}", numero, fatorial);
        }
        // Condição para números negativos.
        else
        {
            // Impressão de mensagem caso números negativos sejam colocados.
            Console.WriteLine("Número inválido! O fatorial só é definido para números não negativos.");
        }
    }
}

// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 6

using System;

public class Questao6
{
    // Função para verificar se um número é positivo ou negativo
    public bool VerificarPositivo(int valor)
    {
        // Verifica se o valor é maior que zero
        if (valor > 0)
        {
            return true; // Retorna verdadeiro se o valor for positivo
        }
        else
        {
            return false; // Retorna falso se o valor for zero ou negativo
        }
    }

    public void Rodar()
    {
        // Solicita ao usuário o número de valores a serem verificados
        Console.Write("Digite a quantidade de valores a serem verificados: ");
        int quantidadeValores = int.Parse(Console.ReadLine());

        // Loop para ler e verificar cada valor
        for (int i = 0; i < quantidadeValores; i++)
        {
            Console.Write($"\nDigite o valor {i + 1}: ");
            int valor = int.Parse(Console.ReadLine());

            // Chama a função para verificar se o valor é positivo ou não
            bool positivo = VerificarPositivo(valor);

            // Exibe uma mensagem se o valor for positivo
            if (positivo)
            {
                Console.WriteLine("O valor é positivo.");
            }
            // Exibe uma mensagem se o valor for negativo
            else
            {
                Console.WriteLine("O valor não é positivo.");
            }
        }
    }
}
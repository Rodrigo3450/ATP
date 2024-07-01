// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 3

using System;

class Program
{
    static void Main()
    {
        // Definição do alfabeto para uso no Código de César
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // Caractere representando espaço
        char espaco = ' ';

        // Solicita ao usuário que digite uma frase para codificação
        Console.WriteLine("Digite uma frase para codificarmos: ");
        string entrada = Console.ReadLine().ToUpper(); // Converte a entrada para maiúsculas para facilitar a comparação

        // Inicializa uma string para armazenar a nova frase codificada
        string novaFrase = "";

        // Itera através dos caracteres da entrada
        for (int j = 0; j < entrada.Length; j++)
        {
            // Itera através do alfabeto para encontrar a correspondência e aplicar o deslocamento de César
            for (int i = 0; i < alfabeto.Length; i++)
            {
                // Verifica se o caractere atual da entrada é uma letra do alfabeto
                if (entrada[j] == alfabeto[i])
                {
                    // Adiciona o caractere codificado à nova frase
                    novaFrase += alfabeto[(i + 3) % alfabeto.Length].ToString();
                    break; // Encerra o loop interno após encontrar a correspondência
                }
                // Verifica se o caractere atual da entrada é um espaço
                else if (entrada[j] == espaco)
                {
                    // Adiciona um espaço à nova frase
                    novaFrase += espaco;
                    break; // Encerra o loop interno após encontrar um espaço
                }
            }
        }

        // Exibe a nova frase codificada
        Console.WriteLine("Nova string codificada: " + novaFrase);
    }
}

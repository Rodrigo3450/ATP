// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 1
// Faça um programa para ler uma frase e contar quantos caracteres são espaços em brancos. 
using System;

class Program
{
    static void Main()
    {
        int resultado;

        string minhaFrase = "My name is Rodrigo";
        Console.WriteLine(minhaFrase);

        resultado = EspacoEmBranco(minhaFrase);
        Console.WriteLine("A quantidade de caracteres que são espaços em branco e de: " + resultado + " caracteres");
    }
    // Função que conta quantos caracteres são espaços em branco.
    static int EspacoEmBranco(string frase)
    {
        int contador = 0;
        // Percorre cada caractere da frase.
        foreach (char count in frase)
        {
            // Verifica se o caractere é um espaço em branco.
            if (count == ' ')
            {
                contador++;
            }
        }
        return contador;
    }
}
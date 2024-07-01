// Nome: Rodrigo Sérgio Alves da Silva 
// Lista 6 Atividade 2
// Faça um programa que receba do usuário uma frase e imprima a frase sem as vogais. 

using System;

class Program
{
    static void Main()
    {
        string frase, resultado;
        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();
        resultado = Notvogal(frase);
        Console.WriteLine("A nova frase sem vogal fica: " + resultado);
    }
    static string Notvogal(string semVogal)
    {
        // Declarando as vogais, que e para serem retiradas
        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // Substituindo cada uma das vogais da frase do usuario por strings vazias.
        foreach (char vogal in vogais)
        {
            semVogal = semVogal.Replace(vogal.ToString(), "");
        }
        return semVogal;
    }
}
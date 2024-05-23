// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 1

using System;

public class Questao1
{
    // Procedimento que calcula e exibe a média conforme o tipo especificado pelo usuario 
    public void CalcularMedia(double nota1, double nota2, double nota3, char tipo)
    {
        double media;

        if (tipo == 'A')
        {
            // Calcula a Média Aritmética
            media = (nota1 + nota2 + nota3) / 3.0;
            Console.WriteLine("Média Aritmética: " + media);
        }
        else if (tipo == 'P')
        {
            // Calcula a Média Ponderada (pesos: 5, 3 e 2)
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10.0;
            Console.WriteLine("Média Ponderada: " + media);
        }
        else
        {
            Console.WriteLine("Tipo de média/calculo inválido.");
        }
    }

    public void Rodar()
    {
        Console.Write("Digite o número de alunos: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Aluno {i + 1}:");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            // ToUpper()), utilizado para o usuario dar entrada com letras maiusculas ou minusculas.
            Console.Write("Digite 'A' para média aritmética ou 'P' para média ponderada: ");
            char tipo = char.Parse(Console.ReadLine().ToUpper());

            // Chama o procedimento para calcular e exibir a média
            CalcularMedia(nota1, nota2, nota3, tipo);
        }
    }
}
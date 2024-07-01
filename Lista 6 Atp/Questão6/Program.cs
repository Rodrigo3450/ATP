// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 6


using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Este programa mostra os divisores de um número inteiro e salva a soma deles em um arquivo.\n");

        // Solicita ao usuário um número inteiro
        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        // Chama o método para mostrar divisores e calcular a soma
        int soma = MostraESomaDivisores(num);

        // Chama o método para criar um arquivo e salvar a soma dos divisores
        CriaArquivo(num, soma);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int MostraESomaDivisores(int numero)
    {
        int soma = 0;

        // Itera de 1 até o número para encontrar os divisores
        for (int i = 1; i <= numero; i++)
        {
            // Verifica se i é divisor de numero
            if (numero % i == 0)
            {
                // Imprime o divisor encontrado
                Console.WriteLine($"{i} é divisor de {numero}");

                // Incrementa a soma com o divisor encontrado
                soma += i;
            }
        }
        return soma;
    }

    static void CriaArquivo(int numero, int soma)
    {
        // Cria um StreamWriter para escrever no arquivo "Exercicio6.txt" em UTF-8
        StreamWriter sw = new StreamWriter("Exercicio6.txt", false, Encoding.UTF8);

        // Escreve no arquivo a mensagem e a soma dos divisores
        sw.WriteLine($"A soma dos divisores de {numero} é: {soma}");

        // Fecha o StreamWriter após escrever no arquivo
        sw.Close();

        Console.WriteLine("\nArquivo Criado: Exercicio6.txt");
    }
}

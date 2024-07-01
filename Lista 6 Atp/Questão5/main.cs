// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 5

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Texto a ser escrito no arquivo
        string texto = "Eu torço para o Barcelona, meu nome é Rodrigo Sérgio Alves da Silva, e eu estudo na PUC Minas no Curso de Análise e Desenvolvimento de Sistemas.";

        // Caminho do arquivo
        string caminho = "Exercicio5.txt";

        try
        {
            // Escrever o texto no arquivo
            File.WriteAllText(caminho, texto);

            // Ler todas as linhas do arquivo recém-criado
            string[] linhas = File.ReadAllLines(caminho);

            // Exibir o conteúdo do arquivo linha por linha
            Console.WriteLine("Conteúdo do arquivo:");
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            // Imprimir quantidade de linhas
            Console.WriteLine($"\nNúmero de linhas no arquivo: {linhas.Length}");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
    }
}

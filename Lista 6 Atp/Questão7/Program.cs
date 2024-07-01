// 
// 

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Solicita ao usuário a quantidade de letras a serem inseridas no arquivo
        Console.WriteLine("Quantas letras você deseja inserir no arquivo:");
        int n = int.Parse(Console.ReadLine());

        // Chama o método CriaArquivo para criar o arquivo e inserir as letras
        CriaArquivo(n);

        Console.WriteLine("\nDigite qualquer tecla para prosseguir...");
        Console.ReadKey();
        Console.Clear();

        // Chama o método LerArquivo para ler as letras do arquivo e contar as vogais
        int count = LerArquivo(n);

        // Exibe a quantidade de vogais encontradas
        Console.WriteLine("Quantidade de vogais encontradas no arquivo: " + count);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void CriaArquivo(int n)
    {
        // Cria um StreamWriter para escrever no arquivo "Exercicio7.txt" em ASCII
        StreamWriter sw = new StreamWriter("Exercicio7.txt", false, Encoding.ASCII);

        // Loop para inserir N letras no arquivo
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite a letra para a posição {i + 1}: ");
            char letra = char.Parse(Console.ReadLine().ToLower());
            sw.Write(letra);
        }

        Console.WriteLine("\nArquivo Criado: Exercicio7.txt\n");

        // Fecha o StreamWriter após escrever no arquivo
        sw.Close();
    }

    static int LerArquivo(int n)
    {
        int qtd = 0;

        // Abre o arquivo para leitura
        StreamReader sr = new StreamReader("Exercicio7.txt");

        // Lê todo o conteúdo do arquivo em uma única string
        string content = sr.ReadToEnd();

        // Itera através das letras lidas do arquivo e conta as vogais
        for (int i = 0; i < content.Length; i++)
        {
            char letra = content[i];
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                qtd++;
        }

        // Fecha o StreamReader após ler todo o arquivo
        sr.Close();

        // Retorna a quantidade total de vogais encontradas
        return qtd;
    }
}

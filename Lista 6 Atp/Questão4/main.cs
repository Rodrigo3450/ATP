// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 4

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Frase a ser escrita no arquivo
        string frase = "Eu sou o Rodrigo, e minha faculdade é Análise e Desenvolvimento de Sistemas";
        string nomeArquivo = "frase.txt";

        try
        {
            // Cria ou sobrescreve o arquivo com a frase especificada
            using (StreamWriter sw = new StreamWriter(nomeArquivo))
            {
                sw.WriteLine(frase);
            }

            Console.WriteLine($"Arquivo '{nomeArquivo}' gerado com sucesso com a seguinte frase:");
            Console.WriteLine(frase);

            // Chama o método para contar os caracteres 'A' no arquivo gerado
            int quantidadeA = ContarCaracteresA(nomeArquivo);
            Console.WriteLine($"\nA quantidade de caracteres 'A' na frase é: {quantidadeA}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao gerar o arquivo: {ex.Message}");
        }
    }

    static int ContarCaracteresA(string nomeArquivo)
    {
        int qtd = 0;

        try
        {
            // Abre o arquivo para leitura
            using (StreamReader sr = new StreamReader(nomeArquivo))
            {
                // Lê o conteúdo completo do arquivo
                string conteudo = sr.ReadToEnd();

                // Itera através dos caracteres do conteúdo
                foreach (char c in conteudo)
                {
                    // Verifica se o caractere atual é 'a' ou 'A'
                    if (c == 'a' || c == 'A')
                    {
                        // Incrementa o contador
                        qtd++;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
        }

        return qtd;
    }
}

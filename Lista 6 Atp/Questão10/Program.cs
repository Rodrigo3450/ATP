// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 10

using System;
using System.IO;
using System.Text;

public class Exercicio10
{
    public static void Main()
    {
        Console.WriteLine("Este programa cria um arquivo 'numeros.txt' com números em ponto flutuante e calcula o máximo, mínimo e média desses valores.\n");
        CriarArquivo();
        CalcularValoresDoArquivo();
    }

    static void CriarArquivo()
    {
        // Caminho do arquivo de saída
        string caminhoArquivo = "numeros.txt";

        try
        {
            // Cria um StreamWriter para escrever no arquivo
            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                // Números em ponto flutuante a serem escritos no arquivo
                double[] numeros = { 11.3, 8.7, 20.2, 12.8, 11.7 };

                // Escreve cada número no arquivo
                foreach (double numero in numeros)
                {
                    sw.WriteLine(numero);
                }
            }

            Console.WriteLine($"Arquivo '{caminhoArquivo}' criado com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
        }
    }

    static void CalcularValoresDoArquivo()
    {
        // Caminho do arquivo de entrada
        string caminhoArquivo = "numeros.txt";

        try
        {
            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine($"O arquivo \"{caminhoArquivo}\" não existe.");
                return;
            }

            // Inicializa as variáveis para armazenar o maior valor, o menor valor e a média
            double maiorValor = double.MinValue, menorValor = double.MaxValue, media = 0;

            // Cria um StreamReader para ler o arquivo
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string line;

                // Inicializa o contador de linhas
                int count = 0;

                // Loop para percorrer as linhas do arquivo
                while ((line = sr.ReadLine()) != null)
                {
                    // Converte a linha para um número em ponto flutuante
                    if (double.TryParse(line, out double numeroAtual))
                    {
                        // Atualiza o maior valor, se necessário
                        if (numeroAtual > maiorValor)
                            maiorValor = numeroAtual;

                        // Atualiza o menor valor, se necessário
                        if (numeroAtual < menorValor)
                            menorValor = numeroAtual;

                        // Adiciona o número à soma para calcular a média
                        media += numeroAtual;

                        // Incrementa o contador de linhas
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"A linha \"{line}\" não pôde ser convertida para um número em ponto flutuante.");
                    }
                }

                // Calcula a média dos valores
                if (count > 0)
                {
                    media = media / count;

                    // Imprime os resultados na tela
                    Console.WriteLine("\nO maior valor é: {0}\nO menor valor é: {1}\nA média dos valores é: {2} ", maiorValor, menorValor, media);
                }
                else
                {
                    Console.WriteLine("\nNenhum número válido encontrado no arquivo.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao ler o arquivo: {ex.Message}");
        }
    }
}

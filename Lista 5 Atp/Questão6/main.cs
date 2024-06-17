// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 6

using System;

public class Program
{
    public static void Main()
    {
        Rodar();
    }

    // Procedimento principal
    public static void Rodar()
    {
        Console.WriteLine("Este programa simula o registro diário de temperaturas ao longo de um mês.");
        Console.WriteLine("As temperaturas são aleatoriamente geradas e variam entre 15ºC e 40ºC.");
        Console.WriteLine("O programa calculará e exibirá a menor temperatura, a maior temperatura, a temperatura média");
        Console.WriteLine("e o número de dias em que a temperatura esteve abaixo da média.\n");

        // Gera o vetor de temperaturas diárias
        double[] temp = ArmazenaTemp();

        // Inicializa variáveis para armazenar a maior, a menor temperatura, e o número de dias abaixo da média
        double maiorTemp = double.MinValue;
        double menorTemp = double.MaxValue;
        int diasAbaixoMedia = 0;

        // Encontra a maior e a menor temperatura no vetor
        MaiorEMenor(ref maiorTemp, ref menorTemp, temp);

        // Calcula a média das temperaturas e conta os dias abaixo da média
        double media = MediaTemp(temp, ref diasAbaixoMedia);

        // Exibe os registros diários de temperatura
        for (int i = 0; i < temp.Length; i++)
        {
            Console.WriteLine($"Dia {i + 1} - {temp[i]:F2}º");
        }

        // Exibe informações finais sobre as temperaturas
        Console.WriteLine("\nResultados:");
        Console.WriteLine("A menor temperatura foi: {0:F2}º", menorTemp);
        Console.WriteLine("A maior temperatura foi: {0:F2}º", maiorTemp);
        Console.WriteLine("A temperatura média foi: {0:F2}º", media);
        Console.WriteLine("O número de dias em que a temperatura esteve abaixo da média é: {0}", diasAbaixoMedia);
    }

    // Função para gerar aleatoriamente um vetor de 31 elementos representando as temperaturas diárias
    static double[] ArmazenaTemp()
    {
        double[] vetorTemperaturas = new double[31];
        Random random = new Random();

        // Preenche o vetor com temperaturas aleatórias entre 15ºC e 40ºC
        for (int i = 0; i < vetorTemperaturas.Length; i++)
        {
            vetorTemperaturas[i] = random.Next(15, 40) + random.NextDouble();
        }

        return vetorTemperaturas;
    }

    // Procedimento para encontrar a maior e a menor temperatura
    static void MaiorEMenor(ref double maior, ref double menor, double[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
                maior = vetor[i];
            if (vetor[i] < menor)
                menor = vetor[i];
        }
    }

    // Função para calcular a média das temperaturas e contar os dias abaixo da média
    static double MediaTemp(double[] vetor, ref int qtdDiasAbaixoMedia)
    {
        double media = 0;

        // Calcula a média das temperaturas
        for (int i = 0; i < vetor.Length; i++)
        {
            media += vetor[i];
        }
        media /= vetor.Length;

        // Conta os dias em que a temperatura esteve abaixo da média
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < media)
                qtdDiasAbaixoMedia++;
        }

        return media;
    }
}

// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 8

using System;
using System.IO;
using System.Text;

public class Exercicio8
{
    public static void Main()
    {
        int veiculos;
        double valor, faturamento_anual, multa, manutencaoAnual;

        // Solicita ao usuário informações sobre a locadora
        Console.WriteLine("Este programa faz o faturamento anual de uma Locadora\n");
        Console.WriteLine("Digite a quantidade de veículos da locadora: ");
        veiculos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do aluguel: ");
        valor = Convert.ToDouble(Console.ReadLine());

        // Calcula o faturamento anual, multa e custo de manutenção anual
        faturamento_anual = FaturamentoAnual(veiculos, valor);
        multa = Multa(veiculos, faturamento_anual);
        manutencaoAnual = ManutencaoAnual(veiculos);

        // Exibe as informações calculadas
        Console.WriteLine("\nFaturamento Anual da Locadora: {0:C}", faturamento_anual);
        Console.WriteLine("Valor Ganho com Multas: {0:C}", multa);
        Console.WriteLine("Valor Gasto com Manutenção: {0:C}", manutencaoAnual);

        // Chama o método CriaArquivo para criar um arquivo de texto com as informações
        CriaArquivo(faturamento_anual, multa, manutencaoAnual);
    }

    static double FaturamentoAnual(int veiculos, double valorDiario)
    {
        double faturamentoMensal = (veiculos * valorDiario) / 3;
        return faturamentoMensal * 12;
    }

    static double Multa(int veiculos, double faturamentoMensal)
    {
        return (faturamentoMensal / 10) * 0.2;
    }

    static double ManutencaoAnual(int veiculos)
    {
        return (veiculos * 0.02) * 600;
    }

    static void CriaArquivo(double faturamentoAnual, double multa, double manutencaoAnual)
    {
        // Cria um StreamWriter para escrever no arquivo "Exercicio8.txt" em ASCII
        StreamWriter sw = new StreamWriter("Exercicio8.txt", false, Encoding.ASCII);

        // Escreve no arquivo as informações da locadora
        sw.WriteLine("Arquivo da Locadora:\n");
        sw.WriteLine("Faturamento Anual da Locadora: " + faturamentoAnual.ToString("C"));
        sw.WriteLine("Valor Ganho com Multas: " + multa.ToString("C"));
        sw.WriteLine("Valor Gasto com Manutenção: " + manutencaoAnual.ToString("C"));

        // Fecha o StreamWriter após escrever no arquivo
        sw.Close();

        Console.WriteLine("\nArquivo Criado!");
    }
}

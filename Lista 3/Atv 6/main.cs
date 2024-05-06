//Nome:Rddrigo Sérgio Alves da Silva
// Lista 3 Atv 6

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        int numFilhos = 0, atecem = 0;
        double salario = 1, mediasal = 0, mediafilh = 0, maior = 0;
        int totalPessoas = 0;

        // Looping enquanto o salário digitado for maior que zero 
        while (salario > 0)
        {
            Console.WriteLine("Digite o seu salário (ou 0 para encerrar): ");
            salario = double.Parse(Console.ReadLine());

            if (salario > 0)
            {
                Console.WriteLine("Digite o número de filhos da sua família: ");
                numFilhos = int.Parse(Console.ReadLine());

                // Incrementa o número total de pessoas
                totalPessoas++;

                // Cálculando a média do salário e do número de filhos
                mediasal += salario;
                mediafilh += numFilhos;

                // Verificando o maior salário
                if (salario > maior)
                {
                    maior = salario;
                }

                // Verificando se o salário é até R$100,00
                if (salario <= 100)
                {
                    atecem++;
                }
            }
        }

        // Calculando as médias
        if (totalPessoas > 0)
        {
            mediasal /= totalPessoas;
            mediafilh /= totalPessoas;
        }

        // Imprimindo os resultados na tela
        Console.WriteLine("Média do salário da população: " + mediasal);
        Console.WriteLine("Média do número de filhos: " + mediafilh);
        Console.WriteLine("Maior salário: " + maior);
        Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + (atecem / (double)totalPessoas) * 100 + "%");
    }
}

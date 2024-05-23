// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 5

using System;

public class Questao5
{
    // Função para calcular o Máximo Divisor Comum (MDC) 
    public int CalculoMDC(int primeiroNumero, int segundoNumero)
    {
        // Enquanto o segundo número for diferente de zero
        while (segundoNumero != 0)
        {
            // Armazena temporariamente o valor do segundo número na variavel (Auxiliar) 
            int aux = segundoNumero;
            // Define o segundo número como o resto da divisão do primeiro número pelo segundo número
            segundoNumero = primeiroNumero % segundoNumero;
            // Define o primeiro número como o valor temporário, que é o divisor original
            primeiroNumero = aux;
        }
        // Quando o segundo número se tornar zero, significa que o primeiro número é o MDC
        return primeiroNumero;
    }

    public void Rodar()
    {
        // Solicita ao usuário os dois números para calcular o MDC
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        // Chama a função para calcular o MDC dos dois números e exibir o resultado
        int mdc = CalculoMDC(numero1, numero2);
        Console.WriteLine($"O MDC de {numero1} e {numero2} é {mdc}.");
    }
}
// Nome: Rodrigo Sérgio Alves da Silva
// Lista 5 Atividade 1

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Exercicio1.Rodar();
    }
}

public class Exercicio1
{
    //Procedimento principal
    public static void Rodar()
    {
        //Declaro um vetor de 20 posições(0 a 19)
        int[] v = new int[20];
        Console.WriteLine("Esse programa aloca 20 números em um vetor e no final mostra o menor valor digitado e sua posição.\r\n");
        //Procedimento principal chama procedimento Declara
        Declara(ref v); //passo o vetor v como referência
                        //Procedimento principal chama procedimento Resultado
        Resultado(v);

    }

    //Procedimento para inserir valores no vetor
    static void Declara(ref int[] v)
    {
        //Repetição para alocar valores no vetor
        for (int i = 0; i < v.Length; i++)
        {
            //Programa pede pro usuário digitar valor
            Console.WriteLine("\r\nDigite um número inteiro para alocarmos na posicao nº{0}: ", i + 1);
            v[i] = int.Parse(Console.ReadLine());
        }
    }
    //Procedimento para achar o menor valor e imprimir resultado
    static void Resultado(int[] v)
    {
        //Declaro variável menorV que recebe o menor valor possível, e variável posição com valor 0
        int menorV = int.MaxValue, posicao = 0;
        //Repetição para percorrer vetor
        for (int i = 0; i < v.Length; i++)
        {
            //Se o valor na posição i for menor que menorV, menorV assume o valor e posição assume i.
            if (v[i] < menorV)
            {
                menorV = v[i];
                posicao = i;
            }
        }
        //Posição incrementa 1 para resultado ser condizente com o programa
        posicao += 1;
        //Programa imprime resultado
        Console.WriteLine("\r\nO menor valor do vetor é {0} e sua posição é de nº{1}", menorV, posicao);
    }
}

// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 10

using System;

class Program
{
    static void Main(string[] args)
    {
        double compra, venda, valortotalc = 0, valortotalv = 0;
        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;

        while (true)
        {
            Console.WriteLine("Digite o preço de compra da mercadoria (digite 0 para encerrar): ");
            compra = double.Parse(Console.ReadLine());
            if (compra == 0)
                break;

            Console.WriteLine("Digite o preço de venda da mercadoria: ");
            venda = double.Parse(Console.ReadLine());

            double lucro = (venda - compra) / compra * 100;

            if (lucro < 10)
                lucroMenor10++;
            else if (lucro >= 10 && lucro <= 20)
                lucroEntre10e20++;
            else
                lucroMaior20++;

            valortotalc += compra;
            valortotalv += venda;
        }

        Console.WriteLine("Quantidade de mercadorias com lucro menor que 10%: " + lucroMenor10);
        Console.WriteLine("Quantidade de mercadorias com lucro entre 10% e 20%: " + lucroEntre10e20);
        Console.WriteLine("Quantidade de mercadorias com lucro maior que 20%: " + lucroMaior20);

        Console.WriteLine("O valor total de compra das mercadorias é de: {0}", valortotalc);
        Console.WriteLine("O valor total de venda das mercadorias é de: {0}", valortotalv);
    }
}
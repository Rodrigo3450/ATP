using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe: ");
        Console.WriteLine("1) para rodar a questão 1");
        Console.WriteLine("2) para rodar a questão 2");
        Console.WriteLine("3) para rodar a questão 3");
        Console.WriteLine("4) para rodar a questão 4");
        Console.WriteLine("5) para rodar a questão 5");
        Console.WriteLine("6) para rodar a questão 6");
        Console.WriteLine("7) para rodar a questão 7");
        Console.WriteLine("8) para rodar a questão 8");
        Console.WriteLine("9) para rodar a questão 9");
        Console.WriteLine("10) para rodar a questão 10");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Questao1 questao1 = new Questao1();
                questao1.Rodar();
                break;
            case 2:
                Questao2 questao2 = new Questao2();
                questao2.Rodar();
                break;
            case 3:
                Questao3 questao3 = new Questao3();
                questao3.Rodar();
                break;
            case 4:
                Questao4 questao4 = new Questao4();
                questao4.Rodar();
                break;
            case 5:
                Questao5 questao5 = new Questao5();
                questao5.Rodar();
                break;
            case 6:
                Questao6 questao6 = new Questao6();
                questao6.Rodar();
                break;
            case 7:
                Questao7 questao7 = new Questao7();
                questao7.Rodar();
                break;
            case 8:
                Questao8 questao8 = new Questao8();
                questao8.Rodar();
                break;
            case 9:
                Questao9 questao9 = new Questao9();
                questao9.Rodar();
                break;
            case 10:
                Questao10 questao10 = new Questao10();
                questao10.Rodar();
                break;
            default:
                Console.WriteLine("Opção invalida!");
                break;
        }
    }
}
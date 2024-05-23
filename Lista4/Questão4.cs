// Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atv 4

using System;

public class Questao4
{
    // Procedimento para verificar e exibir o tipo de triângulo formado pelos lados A, B e C
    public void VerificarTipoTriangulo(double ladoA, double ladoB, double ladoC)
    {
        if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
        {
            Console.WriteLine("Os valores dos lados devem ser positivos.");
            return;
        }

        if (ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA)
        {
            Console.WriteLine("Os valores dos lados não formam um triângulo.");
            return;
        }

        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("Triângulo Equilátero: os comprimentos dos 3 lados são iguais.");
        }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Console.WriteLine("Triângulo Isósceles: os comprimentos de pelo menos 2 lados são iguais.");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno: os comprimentos dos 3 lados são diferentes.");
        }
    }

    public void Rodar()
    {
        double ladoA = 0, ladoB = 0, ladoC = 0;

        // Loop para solicitar os comprimentos dos lados do triângulo
        do
        {
            Console.WriteLine("\nDigite os comprimentos dos lados do triângulo (digite valores negativos para encerrar):");
            try
            {
                Console.Write("Lado A: ");
                ladoA = double.Parse(Console.ReadLine());
                if (ladoA >= 0)
                {
                    Console.Write("Lado B: ");
                    ladoB = double.Parse(Console.ReadLine());
                    if (ladoB >= 0)
                    {
                        Console.Write("Lado C: ");
                        ladoC = double.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, insira números válidos.");
                continue;
            }

            // Verifica se algum dos lados é negativo
            if (ladoA < 0 || ladoB < 0 || ladoC < 0)
            {
                break;
            }

            // Chama o procedimento para verificar o tipo de triângulo
            VerificarTipoTriangulo(ladoA, ladoB, ladoC);
            // Continua o loop indefinidamente até que seja interrompido
        } while (true);
    }
}









// Nome: Rodrigo Sérgio Alves da Silva
// Lista 3 Atividade 11

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis para cada tipo de voto
        int voto1 = 0, voto2 = 0, voto3 = 0, voto4 = 0, votosNulos = 0, votosBranco = 0;
        // Loop para receber os votos até que seja fornecido o valor 0
        while (true)
        {
            // Solicita ao usuário que insira o código do voto
            Console.WriteLine("Digite seu voto (1 a 6) e 0 para encerrar:");
            int voto = int.Parse(Console.ReadLine());

            // Verifica se o voto é 0, que indica o final dos votos
            if (voto == 0)
            {
                break; // Sai do loop se o voto for 0
            }
            else if (voto == 1)
            {
                // Se o voto for para o candidato 1, incrementa o contador correspondente
                voto1++;
            }
            else if (voto == 2)
            {
                // Se o voto for para o candidato 2, incrementa o contador correspondente
                voto2++;
            }
            else if (voto == 3)
            {
                // Se o voto for para o candidato 3, incrementa o contador correspondente
                voto3++;
            }
            else if (voto == 4)
            {
                // Se o voto for para o candidato 4, incrementa o contador correspondente
                voto4++;
            }
            else if (voto == 5)
            {
                // Se o voto for nulo, incrementa o contador correspondente
                votosNulos++;
            }
            else if (voto == 6)
            {
                // Se o voto for em branco, incrementa o contador correspondente
                votosBranco++;
            }
            else
            {
                // Se o código do voto não for válido, exibe uma mensagem de erro
                Console.WriteLine("Código de voto inválido! Por favor, digite um número entre 1 e 6.");
            }
        }

        // Imprime os resultador na tela
        Console.WriteLine("Total de votos para o candidato 1: " + voto1);
        Console.WriteLine("Total de votos para o candidato 2: " + voto2);
        Console.WriteLine("Total de votos para o candidato 3: " + voto3);
        Console.WriteLine("Total de votos para o candidato 4: " + voto4);
        Console.WriteLine("Total de votos nulos: " + votosNulos);
        Console.WriteLine("Total de votos em branco: " + votosBranco);
    }
}

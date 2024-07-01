// Nome: Rodrigo Sérgio Alves da Silva
// Lista 6 Atividade 9

using System;
using System.IO;
using System.Text;

public class Exercicio9
{
    public static void Main()
    {
        // Deleta o arquivo existente para reiniciar o processo
        File.Delete("Exercicio9.txt");

        bool sobrescreve;
        int i = 0;
        Console.WriteLine("\nEste programa armazena dados de alunos. Digite 0 em matrícula para finalizar.\n");
        Opcao(sobrescreve = true, ref i);
    }

    static void MatricularAlunos(bool sobrescreve, ref int i)
    {
        // Cria um StreamWriter para escrever no arquivo "Exercicio9.txt"
        using (StreamWriter sw = new StreamWriter("Exercicio9.txt", sobrescreve, Encoding.ASCII))
        {
            // Se for a primeira vez, escreve o cabeçalho no arquivo
            if (i == 0)
                sw.WriteLine("Alunos - Matrícula | Telefone");

            while (true)
            {
                // Solicita a Matrícula do aluno
                Console.WriteLine("Digite a Matrícula do aluno {0}: ", i + 1);
                int matricula = Convert.ToInt32(Console.ReadLine());

                // Se a Matrícula for 0, encerra o loop
                if (matricula == 0) break;

                // Solicita o telefone de contato do aluno
                Console.WriteLine("Digite o telefone de contato do aluno {0}: ", i + 1);
                double telefone = Convert.ToDouble(Console.ReadLine());

                // Escreve os dados do aluno no arquivo
                sw.WriteLine("Aluno {0} - {1} | {2}", (i + 1).ToString("D4"), matricula.ToString("D4"), telefone.ToString());
                i++;

                // Solicitação para o usuário pressionar qualquer tecla
                Console.WriteLine("\nDigite qualquer tecla para prosseguir...");
                Console.ReadKey();

                // Limpa a tela do console
                Console.Clear();
            }

            // Mensagem indicando que o arquivo foi criado
            Console.WriteLine("\nArquivo Criado!\n");
        }
    }

    static void LerDados()
    {
        // Verifica se o arquivo existe antes de tentar ler
        if (File.Exists("Exercicio9.txt"))
        {
            // Cria um StreamReader para ler o arquivo "Exercicio9.txt"
            using (StreamReader sr = new StreamReader("Exercicio9.txt"))
            {
                // Lê e imprime todas as linhas do arquivo
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("\nArquivo não encontrado.\n");
        }

        // Solicitação para o usuário pressionar qualquer tecla
        Console.WriteLine("\nDigite qualquer tecla para prosseguir...");
        Console.ReadKey();

        // Limpa a tela do console
        Console.Clear();
    }

    static void Opcao(bool sobrescreve, ref int i)
    {
        // Variável para armazenar a opção do usuário
        int op;

        // Loop principal do programa
        while (true)
        {
            // Exibe opções para o usuário
            Console.WriteLine("\nDigite o número de uma das opções abaixo:\n");
            Console.WriteLine("Digite 1 para: Inserir novos alunos");
            Console.WriteLine("Digite 2 para: Sobrescrever arquivo com novos alunos");
            Console.WriteLine("Digite 3 para: Ler dados e escrever no Console");
            Console.WriteLine("Digite 0 para: Finalizar programa");

            // Lê a opção do usuário
            op = Convert.ToInt32(Console.ReadLine());

            // Se a opção for 0, encerra o loop principal
            if (op == 0) break;

            // Executa a opção escolhida pelo usuário
            switch (op)
            {
                case 1:
                    MatricularAlunos(sobrescreve: true, ref i);
                    break;
                case 2:
                    i = 0;
                    MatricularAlunos(sobrescreve: false, ref i);
                    break;
                case 3:
                    LerDados();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}

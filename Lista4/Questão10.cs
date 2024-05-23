//Nome: Rodrigo Sérgio Alves da Silva
// Lista 4 Atividade 10

using System;

public class Questao10
{
    // Método principal do programa
    public void Rodar()
    {
        int idade, conclusao; // Declaração das variáveis

        // Exibe uma mensagem explicando o propósito do programa
        Console.WriteLine("Este programa concede 1 categoria a um nadador de acordo com sua idade");

        // Solicita a idade do nadador ao usuário
        Console.WriteLine("Insira a idade do nadador: ");
        // Lê a idade digitada pelo usuário e converte para um número inteiro
        idade = int.Parse(Console.ReadLine());

        // Chama o método Categoriaidade para determinar a categoria do nadador
        conclusao = Categoriaidade(idade);
    }

    // Método que determina a categoria do nadador com base na idade
    public int Categoriaidade(int idad)
    {
        // Verifica em qual faixa etária a idade se encaixa e exibe a categoria correspondente
        if (idad >= 5 && idad <= 7)
        {
            Console.WriteLine("Categoria F");
        }
        else if (idad >= 8 && idad <= 10)
        {
            Console.WriteLine("Categoria E");
        }
        else if (idad >= 11 && idad <= 13)
        {
            Console.WriteLine("Categoria D");
        }
        else if (idad >= 14 && idad <= 15)
        {
            Console.WriteLine("Categoria C");
        }
        else if (idad >= 16 && idad <= 17)
        {
            Console.WriteLine("Categoria B");
        }
        else if (idad >= 18)
        {
            Console.WriteLine("Categoria A");
        }
        else
        {
            // Caso a idade não se encaixe em nenhuma faixa válida, exibe mensagem de idade inválida
            Console.WriteLine("Idade inválida");
        }

        // Retorna a idade recebida (não é realmente necessário, poderia ser removido)
        return idad;
    }
}

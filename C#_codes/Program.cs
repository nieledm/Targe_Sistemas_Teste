using System;

class Program
{
    // Função 1: Soma de números
    static void Exemplo1()
    {
        // Declaração de variáveis
        int indice = 13;
        int soma = 0;
        int k = 0;

        // Laço para somar
        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        // Impressão do resultado no terminal
        Console.WriteLine("O valor da soma é: " + soma);
    }

    // Função 2: Verificar Fibonacci
    static bool IsFibonacci(int n)
    {
        // Iniciando variáveis
        int a = 0, b = 1;

        // Laço para atualizar valores de a e b
        while (b < n)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        // Se b for igual a n, n pertence à sequência e resposta é true
        return b == n;
    }

    
    static void Main()
    {
        // Chama o exemplo 1
        Exemplo1();

        // Solicita ao usuário um número
        Console.Write("\nInforme um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número pertence à sequência de Fibonacci
        if (IsFibonacci(numero))
        {
            Console.WriteLine("O número " + numero + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não pertence à sequência de Fibonacci.");
        }
    }
}

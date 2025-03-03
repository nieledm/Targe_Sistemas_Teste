using System;

class Exercicio1
{
    public static void Executar()
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
}

class Exercicio2
{
    public static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == n;
    }

    public static void Executar()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

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

class Exercicio3
{
    // Adapte o exercício 3 aqui, criando um método Executar()
    public static void Executar()
    {
        // Seu código do exercício 3 vai aqui
    }
}

class Exercicio4
{
    // Adapte o exercício 4 aqui, criando um método Executar()
    public static void Executar()
    {
        // Seu código do exercício 4 vai aqui
    }
}

class Exercicio5
{
    // Adapte o exercício 5 aqui, criando um método Executar()
    public static void Executar()
    {
        // Seu código do exercício 5 vai aqui
    }
}

class Program
{
    static void Main()
    {
        // Chama os métodos de cada exercício
        // Exercício 1
        Console.WriteLine("Exercício 1");
        Exercicio1.Executar();
        Console.WriteLine();  // Adiciona uma linha em branco entre os resultados dos exercícios

        // Exercício 2
        Console.WriteLine("Exercício 2");
        Exercicio2.Executar();
        Console.WriteLine();

        // Exercício 3
        Console.WriteLine("Exercício 3");
        Exercicio3.Executar();
        Console.WriteLine();

        // Exercício 4
        Console.WriteLine("Exercício 4");
        Exercicio4.Executar();
        Console.WriteLine();

        // Exercício 5
        Console.WriteLine("Exercício 5");
        Exercicio5.Executar();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


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
    public class Dia
    {
        public decimal valor { get; set; }
    }

    public static void Executar()
    {
        // Carregando os dados do JSON
        string json = File.ReadAllText(@"D:\teste_target\dados.json");
        List<Dia> dados = JsonConvert.DeserializeObject<List<Dia>>(json);

        // Filtrando dias com faturamento maior que zero
        List<decimal> faturamentoDiario = new List<decimal>();
        foreach (var dia in dados)
        {
            if (dia.valor > 0)
            {
                faturamentoDiario.Add(dia.valor);
            }
        }

        // Calculando o menor e o maior valor de faturamento
        decimal menorFaturamento = decimal.MaxValue;
        decimal maiorFaturamento = decimal.MinValue;
        foreach (var valor in faturamentoDiario)
        {
            if (valor < menorFaturamento) menorFaturamento = valor;
            if (valor > maiorFaturamento) maiorFaturamento = valor;
        }

        // Calculando a média mensal
        decimal soma = 0;
        foreach (var valor in faturamentoDiario)
        {
            soma += valor;
        }
        decimal mediaMensal = soma / faturamentoDiario.Count;

        // Contando dias com faturamento acima da média
        int diasAcimaDaMedia = 0;
        foreach (var valor in faturamentoDiario)
        {
            if (valor > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        // Exibindo os resultados
        Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

class Exercicio4
{
    public static void Executar()
    {
        // Cadastro de dados, organizados em um dicionário
        Dictionary<string, decimal> faturamentoEstados = new Dictionary<string, decimal>
        {
            { "sp", 67836.43m },
            { "rj", 36678.66m },
            { "mg", 29229.88m },
            { "es", 27165.48m },
            { "outros", 19849.53m }
        };

        // Calculando o total
        decimal totalFaturamento = 0;
        foreach (var valor in faturamentoEstados.Values)
        {
            totalFaturamento += valor;
        }

        // Exibindo os percentuais
        Console.WriteLine("\nO percentual de representação que cada estado foi:");
        foreach (var estado in faturamentoEstados)
        {
            decimal percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}


class Exercicio5
{
    
    public static void Executar()
    {
        
    }
}

class Program
{
    static void Main()
    {
        /*
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
        */

        // Exercício 4
        Console.WriteLine("Exercício 4");
        Exercicio4.Executar();
        Console.WriteLine();

        // Exercício 5
        Console.WriteLine("Exercício 5");
        Exercicio5.Executar();
    }
}

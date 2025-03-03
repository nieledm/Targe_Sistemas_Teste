using System;

class nieleMendes_targetTest_ex1
{
    static void Main()
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

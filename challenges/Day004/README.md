# Day 4

## Desafio:
	Escreva um programa C# que verifique se um número é par ou ímpar e imprima o resultado.

**Resultado:**


```cshap


using System;

namespace Day004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para saber se é par ou ímpar: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)

            Console.WriteLine($"{numero} é um número par.");

        } else
        {
        Console.WriteLine($"{numero} é um número ímpar.");
        }
}
}

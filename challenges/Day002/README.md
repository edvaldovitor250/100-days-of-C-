# Day 2

## Desafio:
	Declare uma variável em C#, atribua um número a ela e imprima o número no console.

**Resultado:**


```cshap

using System;

namespace Day002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Seu número: " + numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Não é um número.");
            }
        }
    }
}


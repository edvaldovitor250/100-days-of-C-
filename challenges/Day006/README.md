# Day 6

## Desafio:

	Implemente um programa C# para verificar se um número é um número primo.

**Resultado:**


```cshap

using System;

namespace Day006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para saber se é Primo: ");
            int numero = int.Parse(Console.ReadLine());

            if (IsPrime(numero))
            {
                Console.WriteLine(numero + " é um número Primo");
            }
            else
            {
                Console.WriteLine(numero + " não é um número Primo");
            }
        }

        static bool IsPrime(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

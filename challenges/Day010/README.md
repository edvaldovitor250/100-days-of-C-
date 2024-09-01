# Day 10

## Desafio:

Escreva um programa C# que converta uma temperatura de Celsius para Fahrenheit e vice-versa.

**Resultado:**


```cshap

using System;

class Program
{
    class Conversor
    {
        public static void Celsius(int valor)
        {
            Console.WriteLine(valor + " °C = " + (valor * 9 / 5 + 32) + " °F");
        }

        public static void Fahrenheit(int valor)
        {
            Console.WriteLine(valor + " °F = " + ((valor - 32) * 5 / 9) + " °C");
        }
    }

    static void Main(string[] args)
    {
        Conversor.Celsius(32);
        Conversor.Fahrenheit(86);
    }
}

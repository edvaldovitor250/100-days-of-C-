# Day 53

## Desafio:

Desenvolva um aplicativo em C# que simule o funcionamento de uma calculadora gráfica, permitindo ao usuário plotar gráficos de funções matemáticas.

**Resultado:**

```cshap
using System;
using System.Collections.Generic;

namespace ConsoleGraphingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma função matemática (ex: x^2):");
            string userFunction = Console.ReadLine();

            for (int y = 10; y >= -10; y--)
            {
                for (int x = -20; x <= 20; x++)
                {
                    double result = EvaluateFunction(userFunction, x / 2.0);
                    if (Math.Round(result) == y)
                    {
                        Console.Write("*");
                    }
                    else if (x == 0 && y == 0)
                    {
                        Console.Write("+");
                    }
                    else if (x == 0)
                    {
                        Console.Write("|");
                    }
                    else if (y == 0)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static double EvaluateFunction(string function, double x)
        {
            string expression = function.Replace("x", x.ToString());
            return Evaluate(expression);
        }

        static double Evaluate(string expression)
        {
            var dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }
    }
}

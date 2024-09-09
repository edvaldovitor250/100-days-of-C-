# Day 18

## Desafio:

Implemente um programa C# que calcule o valor de π (pi) usando a série de Leibniz.

**Resultado:**

```cshap

static double CalculoPi(double p, double d, double c)
{
    double pi = 4 * (p * d) / c;
    Console.WriteLine(pi); 
    return pi;             
}

double resultado = CalculoPi(3, 3, 3);
Console.WriteLine("Resultado: " + resultado);

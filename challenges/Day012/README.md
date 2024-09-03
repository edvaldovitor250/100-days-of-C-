# Day 12

## Desafio:

Implemente um programa C# que calcule a média de uma lista de números.

**Resultado:**


```cshap

List<int> numeros = new List<int>{2,4,5,7,5,10};

int soma = 0;


foreach (int numero in numeros)
{
    soma += numero;
}

double media = (double)soma / numeros.Count;

Console.WriteLine("A média dos valores é: " + media.ToString("F2"));

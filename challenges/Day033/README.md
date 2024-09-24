# Day 33

## Desafio:

	Escreva um programa em C# que implemente o algoritmo de ordenação quicksort para ordenar uma lista de números inteiros.

**Resultado:**

```cshap

List<int> numeros = new List<int> { 4, 2, 2, 3, 54, 6, 2, 3, 2432, 423, 432, 423 };
numeros.Sort();

foreach (int item in numeros)
{
    Console.WriteLine(item);
} 
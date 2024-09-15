# Day 24

## Desafio:

Implemente um programa C# que realize a busca binária em um array ordenado.

**Resultado:**

```cshap

List<int> lista = new List<int>(){234,21,65,34,22,90,1};

Console.WriteLine("Listagem dos valores em ordem crescente:");

lista.Sort();

foreach (int numero in lista)
{
    Console.WriteLine(numero);
}

Console.WriteLine("Resultado da busca binária para o número 1:");

Console.WriteLine(lista.BinarySearch(1));
# Day 7

## Desafio:

	Escreva um programa C# que inverta uma string.

**Resultado:**


```cshap

 Console.WriteLine($"Escreva um texto: ");
 
 string text = Console.ReadLine();
 
string textoInvertido = new string(text.Reverse().ToArray());

 Console.WriteLine($"Texto Invertido: {textoInvertido}");


# Day 22

## Desafio:

Escreva um programa C# que simule um jogo de dados (dados de 6 faces) com lançamentos e contagem de pontos.

**Resultado:**

```cshap

 static void GeradorDado(int numero){

 Random rand = new Random();
int rando =  rand.Next(numero, 7);
 Console.WriteLine(rando);
 }

 GeradorDado(6);
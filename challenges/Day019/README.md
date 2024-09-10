# Day 19

## Desafio:

Escreva um programa C# que gere os primeiros N números da sequência de Fibonacci.

**Resultado:**

```cshap



 Console.WriteLine("Digite o valor de N para gerar os primeiros N números da sequência de Fibonacci:");
        int N = int.Parse(Console.ReadLine());

        Fibonacci(N);


 static void Fibonacci(int N)
    {
        int a = 0, b = 1, c;

        if (N >= 1)
            Console.Write(a + " ");  

        if (N >= 2)
            Console.Write(b + " ");  

        for (int i = 3; i <= N; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
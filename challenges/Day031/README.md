# Day 31

## Desafio:

	Escreva um programa C# que calcule o valor do seno de um ângulo usando a série de Taylor.
**Resultado:**

```cshap


    {
        Console.Write("Digite o valor do ângulo em graus: ");
        double graus = Convert.ToDouble(Console.ReadLine());

        double radianos = graus * (Math.PI / 180);

        double seno = CalcularSenoTaylor(radianos);

        Console.WriteLine($"O valor aproximado do seno de {graus} graus é: {seno}");

    static double CalcularSenoTaylor(double x)
    {
        int termos = 10;
        double seno = 0;

        for (int n = 0; n < termos; n++)
        {
            double termo = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Fatorial(2 * n + 1);
            seno += termo;
        }

        return seno;
    }

    static double Fatorial(int n)
    {
        double fatorial = 1;
        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}

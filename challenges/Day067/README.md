# Day 67

## Desafio:

Desenvolva um aplicativo em C# que simule o funcionamento de uma caixa registradora, com funcionalidades para calcular troco e registrar compras.

**Resultado:**

```cshap

using System;

public class CaixaRegistradora
{
    public string Produto { get; set; }
    public int Preco { get; set; }
    public int Quantidade { get; set; }
    public int Total { get; set; }

    public void CalcularTroco(int valorPago)
    {
        int totalCompra = Preco * Quantidade;
        int troco = valorPago - totalCompra;

        Console.WriteLine("Total da Compra: " + totalCompra);

        if (troco < 0)
        {
            Console.WriteLine("Valor pago insuficiente. Faltam: " + Math.Abs(troco));
        }
        else
        {
            Console.WriteLine("Troco: " + troco);
        }
    }

    public void RegistrarCompra()
    {
        Total = Preco * Quantidade;
        Console.WriteLine("Produto: " + Produto);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Total: " + Total);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CaixaRegistradora caixa = new CaixaRegistradora();

        caixa.Produto = "Caderno";
        caixa.Preco = 10;
        caixa.Quantidade = 3;

        caixa.RegistrarCompra();

        int valorPago = 50;
        caixa.CalcularTroco(valorPago);
    }
}

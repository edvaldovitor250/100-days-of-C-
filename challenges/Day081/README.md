# Day 81

## Desafio:

Escreva um programa C# que implemente um sistema de gerenciamento de um restaurante, permitindo gerenciar mesas, pedidos e pagamentos.
        
**Resultado:**

```cshap

public class GerenciamentoRestaurante
{
    List<string> mesas = new List<string>();
    List<string> pedidos = new List<string>();
    List<int> pagamentos = new List<int>();

    public void gerenciamentoMesa(string mesa, string pedido,int pagamento)
    {
        mesas.Add(mesa);
        pedidos.Add(pedido);
        pagamentos.Add(pagamento);
        Console.WriteLine($"Pedido '{pedido}' servido para a mesa '{mesa}' e pago com '{pagamento}'.");
    }

    public void gerenciamentoPedido(string pedido, string mesa)
    {
        if (mesas.Contains(mesa))
        {
            int index = mesas.IndexOf(mesa);
            pedidos[index] = pedido;
            Console.WriteLine($"Pedido '{pedido}' atualizado para a mesa '{mesa}'.");
        }
        else
        {
            Console.WriteLine($"Mesa '{mesa}' não encontrada.");
        }
    }

    public void gerenciarPagamento(string pedido, int pagamento)
    {
        int index = pedidos.IndexOf(pedido);
        if (index >= 0)
        {
            pagamentos[index] = pagamento;
            Console.WriteLine($"Pagamento de '{pagamento}' para o pedido '{pedido}' confirmado.");
        }
        else
        {
            Console.WriteLine($"Pedido '{pedido}' não encontrado.");
        }
    }

    public static void Main()
    {
        GerenciamentoRestaurante restaurante = new GerenciamentoRestaurante();

        restaurante.gerenciamentoMesa("Mesa 1", "Pizza", 50);
        restaurante.gerenciamentoMesa("Mesa 2", "Pasta", 30);
        restaurante.gerenciamentoMesa("Mesa 3", "Salada", 20);

        restaurante.gerenciamentoPedido("Sushi", "Mesa 1");

        restaurante.gerenciarPagamento("Sushi", 60);

        restaurante.gerenciamentoPedido("Bebida", "Mesa 4");

        restaurante.gerenciarPagamento("Sobremesa", 15);
    }
}
using System;
using System.Collections.Generic;

public enum StatusEntrega
{
    Pendente,
    EmTransito,
    Entregue,
    Cancelado
}

public class Pedido
{
    public string Id { get; set; }
    public string Descricao { get; set; }
    public StatusEntrega Status { get; set; }

    public Pedido(string id, string descricao)
    {
        Id = id;
        Descricao = descricao;
        Status = StatusEntrega.Pendente; 
    }
}

public class RastreamentoEntregas
{
    private List<Pedido> pedidos = new List<Pedido>();

    public void AdicionarPedido(string id, string descricao)
    {
        var pedido = new Pedido(id, descricao);
        pedidos.Add(pedido);
        Console.WriteLine($"Pedido '{id}' adicionado com status: {pedido.Status}");
    }

    public void AtualizarStatus(string id, StatusEntrega novoStatus)
    {
        var pedido = pedidos.Find(p => p.Id == id);
        if (pedido != null)
        {
            pedido.Status = novoStatus;
            Console.WriteLine($"Status do pedido '{id}' atualizado para: {novoStatus}");
        }
        else
        {
            Console.WriteLine($"Pedido '{id}' não encontrado.");
        }
    }

    public void ExibirStatusPedidos()
    {
        Console.WriteLine("Status dos Pedidos:");
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"ID: {pedido.Id}, Descrição: {pedido.Descricao}, Status: {pedido.Status}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var sistemaRastreamento = new RastreamentoEntregas();

        sistemaRastreamento.AdicionarPedido("001", "Pedido de notebook");
        sistemaRastreamento.AdicionarPedido("002", "Pedido de smartphone");

        sistemaRastreamento.AtualizarStatus("001", StatusEntrega.EmTransito);
        sistemaRastreamento.AtualizarStatus("002", StatusEntrega.Entregue);

        sistemaRastreamento.ExibirStatusPedidos();
    }
}

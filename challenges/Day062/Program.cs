using System;
using System.Collections.Generic;

public class CorretoraAcoes
{
    List<string> bancosDeAcoes = new List<string> {
        "Wall Street Holdings",
        "Nova York Investimentos",
        "Capital Brokers",
        "Mercado Global",
        "Futuro Financeiro",
        "Risco Zero Invest",
        "Alfa Traders",
        "Equity Partners",
        "BlueChip Capital",
        "Liberty Assets"
    };

    List<double> acoes = new List<double> { 3, 4, 2, 6, 5, 3, 5, 2, 10 };

    public string ComprarAcao(string nome, double acao)
    {
        bancosDeAcoes.Add(nome);
        acoes.Add(acao);

        return $"Sua ação foi comprada: {nome}, Valor: {acao}";
    }

    public string VenderAcao(string nome, double acao)
    {
        int index = bancosDeAcoes.IndexOf(nome);
        int index2 = acoes.IndexOf(acao);

        if (index >= 0 && index2 >= 0)
        {
            bancosDeAcoes.RemoveAt(index);
            acoes.RemoveAt(index2);
            return "Sua ação foi vendida.";
        }
        else
        {
            return "Você não possui essa ação ou não existe um banco de ações com esse nome.";
        }
    }

    public string ObterAnaliseAcoes(double acao)
    {
        int index = acoes.IndexOf(acao);
        if (index != -1)
        {
            return bancosDeAcoes[index];
        }
        else
        {
            return "Nenhum banco de ações encontrado com esse valor.";
        }
    }

    public static void Main(string[] args)
    {
        CorretoraAcoes corretora = new CorretoraAcoes();

        string compraResultado = corretora.ComprarAcao("Investimentos Brasil", 7.5);
        Console.WriteLine(compraResultado);

        string vendaResultado = corretora.VenderAcao("Capital Brokers", 2);
        Console.WriteLine(vendaResultado);

        string analiseResultado = corretora.ObterAnaliseAcoes(5);
        Console.WriteLine($"Análise: {analiseResultado}");

        string vendaInvalida = corretora.VenderAcao("Não Existe", 10);
        Console.WriteLine(vendaInvalida);
    }
}

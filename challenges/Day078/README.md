# Day 78

## Desafio:

	Crie um sistema C# para gerenciar um estúdio de fotografia, com funcionalidades para agendamento de sessões, gerenciamento de clientes e edição de fotos.
        
**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class EstudioFotografia
{
    List<string> sessoes = new List<string>();  
    List<string> agendamentos = new List<string>();

    public string AgendarSessao(string sessao, string agendamento)
    {
        if (sessoes.Contains(sessao))
        {
            agendamentos.Add(agendamento);
            return "Agendamento realizado com sucesso.";
        }
        else
        {
            return "Sessão não encontrada.";
        }
    }

    public string EditarFotos(string sessao, string foto)
    {
        if (sessoes.Contains(sessao))
        {
            return "Fotos editadas com sucesso.";
        }
        else
        {
            return "Sessão não encontrada.";
        }
    }

    static void Main(string[] args)  
    {
        EstudioFotografia estudio = new EstudioFotografia();
        
        estudio.sessoes.Add("1");

        Console.WriteLine(estudio.AgendarSessao("1", "02/09/2022"));
        Console.WriteLine(estudio.EditarFotos("1", "http://www.google.com?q=fotos+sites"));
    }
}

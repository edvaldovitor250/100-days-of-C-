public class GereciamentoDeSeguranca
{
    List<string> contratos = new List<string>();
    List<string> clientes  = new List<string>();
    List<string> equipes  = new List<string>();

    public void Adicionar(Object obj)
    {
        if(obj is Contrato)
        {
            contratos.Add(obj.ToString());
        }
        else if(obj is Cliente)
        {
            clientes.Add(obj.ToString());
        }
        else if(obj is Equipe)
        {
            equipes.Add(obj.ToString());
        }
    }

    public void Remover(Object obj)
    {
        if(obj is Contrato)
        {
            contratos.Remove(obj.ToString());
        }
        else if(obj is Cliente)
        {
            clientes.Remove(obj.ToString());
        }
        else if(obj is Equipe)
        {
            equipes.Remove(obj.ToString());
        }
    }

    public void Atualizar(Object obj)
    {
        if(obj is Contrato)
        {
            contratos[contratos.IndexOf(obj.ToString())] = obj.ToString();
        }
        else if(obj is Cliente)
        {
            clientes[clientes.IndexOf(obj.ToString())] = obj.ToString();
        }
        else if(obj is Equipe)
        {
            equipes[equipes.IndexOf(obj.ToString())] = obj.ToString();
        }
    }

    public void Listar()
    {
        Console.WriteLine("Contratos:");
        foreach(var contrato in contratos)
        {
            Console.WriteLine(contrato);
        }

        Console.WriteLine("Clientes:");
        foreach(var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("Equipes:");
        foreach(var equipe in equipes)
        {
            Console.WriteLine(equipe);
        }
    }
    
}
 public static void Main()
    {
        GereciamentoDeSeguranca sistema = new GereciamentoDeSeguranca();

        Contrato contrato1 = new Contrato("Contrato 1");
        Contrato contrato2 = new Contrato("Contrato 2");

        Cliente cliente1 = new Cliente("Cliente A");
        Cliente cliente2 = new Cliente("Cliente B");

        Equipe equipe1 = new Equipe("Equipe Alpha");
        Equipe equipe2 = new Equipe("Equipe Beta");

        sistema.Adicionar(contrato1);
        sistema.Adicionar(contrato2);

        sistema.Adicionar(cliente1);
        sistema.Adicionar(cliente2);

        sistema.Adicionar(equipe1);
        sistema.Adicionar(equipe2);

        sistema.Listar();

        sistema.Remover(cliente1);
        sistema.Remover(equipe2);

        sistema.Atualizar(new Contrato("Contrato Atualizado 2"));

        sistema.Listar();
    }
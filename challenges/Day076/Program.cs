using System;
using System.Collections.Generic;

public class ClinicaOdontologica
{
    private List<Paciente> pacientes = new List<Paciente>();
    private List<Consulta> consultas = new List<Consulta>();
    private int proximoIdPaciente = 1;
    private int proximoIdConsulta = 1;
    private int proximoIdProntuario = 1;

    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Prontuario> Prontuarios { get; set; }

        public Paciente(int id, string nome, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Prontuarios = new List<Prontuario>();
        }
    }

    public class Consulta
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public Consulta(int id, Paciente paciente, DateTime data, string status)
        {
            Id = id;
            Paciente = paciente;
            Data = data;
            Status = status;
        }
    }

    public class Prontuario
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Observacoes { get; set; }

        public Prontuario(int id, DateTime dataRegistro, string observacoes)
        {
            Id = id;
            DataRegistro = dataRegistro;
            Observacoes = observacoes;
        }
    }

    public Paciente CadastrarPaciente(string nome, string telefone, string email)
    {
        var paciente = new Paciente(proximoIdPaciente++, nome, telefone, email);
        pacientes.Add(paciente);
        return paciente;
    }

    public Consulta AgendarConsulta(Paciente paciente, DateTime data)
    {
        var consulta = new Consulta(proximoIdConsulta++, paciente, data, "Agendada");
        consultas.Add(consulta);
        return consulta;
    }

    public Prontuario AdicionarProntuario(Paciente paciente, string observacoes)
    {
        var prontuario = new Prontuario(proximoIdProntuario++, DateTime.Now, observacoes);
        paciente.Prontuarios.Add(prontuario);
        return prontuario;
    }

    public List<Paciente> ListarPacientes()
    {
        return pacientes;
    }

    public List<Consulta> ListarConsultas()
    {
        return consultas;
    }

    public List<Prontuario> ConsultarProntuarios(Paciente paciente)
    {
        return paciente.Prontuarios;
    }
}

public class Program
{
    public static void Main()
    {
        var clinica = new ClinicaOdontologica();

        var paciente = clinica.CadastrarPaciente("João Silva", "123-456-7890", "joao@exemplo.com");
        Console.WriteLine($"Paciente cadastrado: {paciente.Nome}");

        var consulta = clinica.AgendarConsulta(paciente, DateTime.Now.AddDays(7));
        Console.WriteLine($"Consulta agendada para {consulta.Data} com o paciente {consulta.Paciente.Nome}");

        var prontuario = clinica.AdicionarProntuario(paciente, "Primeira consulta. Observado necessidade de limpeza.");
        Console.WriteLine($"Prontuário registrado para {paciente.Nome} com observação: {prontuario.Observacoes}");

        Console.WriteLine("\nLista de pacientes:");
        foreach (var p in clinica.ListarPacientes())
        {
            Console.WriteLine($"- {p.Nome}, Telefone: {p.Telefone}");
        }

        Console.WriteLine("\nLista de consultas:");
        foreach (var c in clinica.ListarConsultas())
        {
            Console.WriteLine($"- Consulta com {c.Paciente.Nome} em {c.Data}, Status: {c.Status}");
        }

        Console.WriteLine($"\nProntuários de {paciente.Nome}:");
        foreach (var pr in clinica.ConsultarProntuarios(paciente))
        {
            Console.WriteLine($"- Data: {pr.DataRegistro}, Observações: {pr.Observacoes}");
        }
    }
}

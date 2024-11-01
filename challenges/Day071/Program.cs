using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAgendamentoConsultas
{
    public class Consulta
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataHora { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Paciente: {NomePaciente} | Data e Hora: {DataHora}";
        }
    }

    public class Program
    {
        static List<Consulta> consultas = new List<Consulta>();
        static int contadorId = 1;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Agendamento de Consultas Médicas");
                Console.WriteLine("1. Adicionar Consulta");
                Console.WriteLine("2. Editar Consulta");
                Console.WriteLine("3. Cancelar Consulta");
                Console.WriteLine("4. Listar Consultas");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarConsulta();
                        break;
                    case "2":
                        EditarConsulta();
                        break;
                    case "3":
                        CancelarConsulta();
                        break;
                    case "4":
                        ListarConsultas();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void AdicionarConsulta()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Nova Consulta");

            Console.Write("Nome do Paciente: ");
            string nomePaciente = Console.ReadLine();

            Console.Write("Data e Hora (dd/MM/yyyy HH:mm): ");
            DateTime dataHora;
            while (!DateTime.TryParse(Console.ReadLine(), out dataHora))
            {
                Console.Write("Formato inválido. Digite novamente (dd/MM/yyyy HH:mm): ");
            }

            var consulta = new Consulta
            {
                Id = contadorId++,
                NomePaciente = nomePaciente,
                DataHora = dataHora
            };
            consultas.Add(consulta);

            Console.WriteLine("\nConsulta adicionada com sucesso!");
        }

        private static void EditarConsulta()
        {
            Console.Clear();
            Console.WriteLine("Editar Consulta");
            ListarConsultas();

            Console.Write("\nDigite o ID da consulta para editar: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || !consultas.Any(c => c.Id == id))
            {
                Console.Write("ID inválido. Digite novamente: ");
            }

            var consulta = consultas.First(c => c.Id == id);

            Console.Write("Novo Nome do Paciente: ");
            consulta.NomePaciente = Console.ReadLine();

            Console.Write("Nova Data e Hora (dd/MM/yyyy HH:mm): ");
            while (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
            {
                Console.Write("Formato inválido. Digite novamente (dd/MM/yyyy HH:mm): ");
            }
            consulta.DataHora = dataHora;

            Console.WriteLine("\nConsulta editada com sucesso!");
        }

        private static void CancelarConsulta()
        {
            Console.Clear();
            Console.WriteLine("Cancelar Consulta");
            ListarConsultas();

            Console.Write("\nDigite o ID da consulta para cancelar: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || !consultas.Any(c => c.Id == id))
            {
                Console.Write("ID inválido. Digite novamente: ");
            }

            consultas.RemoveAll(c => c.Id == id);
            Console.WriteLine("\nConsulta cancelada com sucesso!");
        }

        private static void ListarConsultas()
        {
            Console.Clear();
            Console.WriteLine("Lista de Consultas Agendadas");

            if (consultas.Count == 0)
            {
                Console.WriteLine("Nenhuma consulta agendada.");
            }
            else
            {
                foreach (var consulta in consultas)
                {
                    Console.WriteLine(consulta);
                }
            }
        }
    }
}

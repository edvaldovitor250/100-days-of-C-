using System;
using System.Collections.Generic;

namespace Day045
{
    public class GerenciarHospital
    {
        List<string> pacientes;
        List<string> consultas;
        public List<string> medicos;

        public GerenciarHospital()
        {
            pacientes = new List<string>();
            consultas = new List<string>();
            medicos = new List<string>();
        }

        public void AdicionarPacientes(string paciente)
        {
            if (!pacientes.Contains(paciente))
            {
                pacientes.Add(paciente);
                Console.WriteLine($"{paciente} foi adicionado ao sistema.");
            }
            else
            {
                Console.WriteLine("Já existe");
            }
        }

        public void AgendarConsultas(string consulta)
        {
            if (!consultas.Contains(consulta))
            {
                consultas.Add(consulta);
                Console.WriteLine($"Consulta agendada para {consulta}.");
            }
            else
            {
                Console.WriteLine("Já existe");
            }
        }

        public void AtenderConsulta(string medico, string paciente)
        {
            if (medicos.Contains(medico) && pacientes.Contains(paciente))
            {
                Console.WriteLine($"Médico {medico} atendeu ao paciente {paciente}.");
            }
            else
            {
                Console.WriteLine("Médico ou paciente não encontrado.");
            }
        }
    }
}

# Day 45

## Desafio:

Desenvolva um aplicativo em C# que permita ao usuário criar e manipular arquivos PDF, como adicionar páginas, texto e imagens.

**Resultado:**

```cshap

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

using System;

namespace Day045
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciarHospital hospital = new GerenciarHospital();

            hospital.AdicionarPacientes("João Silva");
            hospital.AdicionarPacientes("Maria Oliveira");
            hospital.AdicionarPacientes("João Silva"); 

            hospital.AgendarConsultas("Consulta com o Dr. Paulo - 15/10/2024");
            hospital.AgendarConsultas("Consulta com a Dra. Ana - 16/10/2024");
            hospital.AgendarConsultas("Consulta com o Dr. Paulo - 15/10/2024"); 

            hospital.medicos.Add("Dr. Paulo");
            hospital.medicos.Add("Dra. Ana");

            hospital.AtenderConsulta("Dr. Paulo", "João Silva");
            hospital.AtenderConsulta("Dra. Ana", "Maria Oliveira");
            hospital.AtenderConsulta("Dr. Paulo", "José Souza"); 
            hospital.AtenderConsulta("Dr. Ricardo", "João Silva"); 
        }
    }
}


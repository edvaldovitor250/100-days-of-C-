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

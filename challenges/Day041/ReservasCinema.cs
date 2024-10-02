using System;
using System.Collections.Generic;

namespace Day041
{
    public class ReservasCinema
    {
        List<string> cinema; 
        List<int> assentos; 

        public ReservasCinema()
        {
            cinema = new List<string>();
            assentos = new List<int>();
        }

        public void ReservarAssento(int assento)
        {
            if (assento >= 1 && assento <= 150) 
            {
                if (!assentos.Contains(assento))
                {
                    assentos.Add(assento);
                    Console.WriteLine($"Assento {assento} reservado com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Assento {assento} já está reservado.");
                }
            }
            else
            {
                Console.WriteLine("Número de assento inválido. Escolha um número entre 1 e 150.");
            }
        }

        public void ListarAssentosDisponiveis()
        {
            Console.WriteLine("Assentos disponíveis:");
            for (int i = 1; i <= 150; i++)
            {
                if (!assentos.Contains(i)) 
                {
                    Console.WriteLine($"Assento {i} está disponível.");
                }
            }
        }
    }
}

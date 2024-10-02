# Day 41

## Desafio:

	Escreva um programa C# que simule o funcionamento de um sistema de reservas em um cinema, permitindo a reserva de assentos e a visualização de sessões disponíveis.

**Resultado:**

```cshap

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


ReservasCinema reservas = new ReservasCinema();

reservas.ListarAssentosDisponiveis();

reservas.ReservarAssento(10);
reservas.ReservarAssento(25);
reservas.ReservarAssento(150);

reservas.ReservarAssento(10);

reservas.ReservarAssento(200);

reservas.ListarAssentosDisponiveis();
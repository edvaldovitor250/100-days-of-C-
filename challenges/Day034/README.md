# Day 34

## Desafio:

	Desenvolva um aplicativo C# que simule o funcionamento de um sistema de reserva de passagens aéreas, permitindo a reserva, cancelamento e visualização de voos.

**Resultado:**

```cshap


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day034
{
    public class SistemaPassagens
    {
        List<string> reserva;
        List<int> valor;

        public void SistemaPassagens(){
            reserva = new List<string>();
            valor = new List<int>();
        }

        public void reservaPassagem(string passagens, int valorers){
            reserva.Add(passagens);
            valor.Add(valorers);
            Console.WriteLine( passagens + " " + valorers );
        }

        public void RemoverReserva(string passagens)
        {
            int index = reserva.IndexOf(passagens);
            if (index != -1)
            {
                reserva.RemoveAt(index);
                valor.RemoveAt(index);
                Console.WriteLine(passagens + " removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }
         public void ListarVoos()
        {
            if (reserva.Count == 0)
            {
                Console.WriteLine("Nenhuma reserva encontrada.");
                return;
            }

            Console.WriteLine("Reservas atuais:");
            for (int i = 0; i < reserva.Count; i++)
            {
                Console.WriteLine($"{reserva[i]} - R${valor[i]}");
            }
        }


    }
}

 SistemaPassagens sistema = new SistemaPassagens();

            sistema.ReservaPassagem("Voo SP - RJ", 500);
            sistema.ReservaPassagem("Voo Brasília - Salvador", 350);
            sistema.ReservaPassagem("Voo Recife - Fortaleza", 420);

            sistema.ListarVoos();

            sistema.RemoverReserva("Voo SP - RJ");

            sistema.ListarVoos();
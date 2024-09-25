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
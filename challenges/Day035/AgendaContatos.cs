using System;
using System.Collections.Generic;

namespace Day035
{
    public class AgendaContatos
    {
        List<string> contatos;
        List<int> numeros;

        public AgendaContatos()
        {
            contatos = new List<string>();
            numeros = new List<int>();
        }

        public void AdicionarContato(string contato, int numero)
        {
            contatos.Add(contato);
            numeros.Add(numero);
            Console.WriteLine($"Contato {contato} com número {numero} adicionado.");
        }

        public void RemoverContato(string contato, int numero)
        {
            int index = contatos.IndexOf(contato);
            if (index != -1 && numeros[index] == numero)
            {
                contatos.RemoveAt(index);
                numeros.RemoveAt(index);
                Console.WriteLine($"Contato {contato} removido.");
            }
            else
            {
                Console.WriteLine("Contato ou número não encontrado.");
            }
        }

        public void AtualizarContato(string contatoAntigo, string contatoNovo, int numeroAntigo, int numeroNovo)
        {
            int index = contatos.IndexOf(contatoAntigo);
            if (index != -1 && numeros[index] == numeroAntigo)
            {
                contatos[index] = contatoNovo;
                numeros[index] = numeroNovo;
                Console.WriteLine($"Contato {contatoAntigo} atualizado para {contatoNovo} com o número {numeroNovo}.");
            }
            else
            {
                Console.WriteLine("Contato ou número não encontrado para atualizar.");
            }
        }

        public void ExibirContatos()
        {
            for (int i = 0; i < contatos.Count; i++)
            {
                Console.WriteLine($"Contato: {contatos[i]}, Número: {numeros[i]}");
            }
        }
    }
}

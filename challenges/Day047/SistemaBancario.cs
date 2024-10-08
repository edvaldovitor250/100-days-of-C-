using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day047
{
     public class SistemaBancario
    {
        List<string> contas = new List<string>();
        List<int> saldos = new List<int>();
        List<List<string>> extratos = new List<List<string>>(); // Extrato de transações para cada conta

        public void CriarConta(string nome, int saldoInicial)
        {
            if (!contas.Contains(nome))
            {
                contas.Add(nome);
                saldos.Add(saldoInicial);
                extratos.Add(new List<string> { $"Conta criada com saldo inicial de {saldoInicial} em {DateTime.Now}" });
                Console.WriteLine($"Conta {nome} criada com saldo inicial de {saldoInicial}.");
            }
            else
            {
                Console.WriteLine($"Já existe uma conta com o nome {nome}.");
            }
        }

        public void Sacar(string nome, int valor)
        {
            int index = contas.IndexOf(nome);
            if (index >= 0)
            {
                if (saldos[index] >= valor)
                {
                    saldos[index] -= valor;
                    extratos[index].Add($"Saque de {valor} em {DateTime.Now}");
                    Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {saldos[index]}.");
                }
                else
                {
                    Console.WriteLine($"Saldo insuficiente para realizar o saque de {valor}.");
                }
            }
            else
            {
                Console.WriteLine($"Conta {nome} não encontrada.");
            }
        }

        public void Depositar(string nome, int valor)
        {
            int index = contas.IndexOf(nome);
            if (index >= 0)
            {
                saldos[index] += valor;
                extratos[index].Add($"Depósito de {valor} em {DateTime.Now}");
                Console.WriteLine($"Depósito de {valor} realizado com sucesso. Saldo atual: {saldos[index]}.");
            }
            else
            {
                Console.WriteLine($"Conta {nome} não encontrada.");
            }
        }

        public void Transferir(string nomeOrigem, string nomeDestino, int valor)
        {
            int indexOrigem = contas.IndexOf(nomeOrigem);
            int indexDestino = contas.IndexOf(nomeDestino);

            if (indexOrigem >= 0 && indexDestino >= 0)
            {
                if (saldos[indexOrigem] >= valor)
                {
                    saldos[indexOrigem] -= valor;
                    saldos[indexDestino] += valor;

                    extratos[indexOrigem].Add($"Transferência de {valor} para {nomeDestino} em {DateTime.Now}");
                    extratos[indexDestino].Add($"Recebimento de {valor} de {nomeOrigem} em {DateTime.Now}");

                    Console.WriteLine($"Transferência de {valor} de {nomeOrigem} para {nomeDestino} realizada com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Saldo insuficiente para realizar a transferência.");
                }
            }
            else
            {
                if (indexOrigem < 0)
                {
                    Console.WriteLine($"Conta de origem {nomeOrigem} não encontrada.");
                }
                if (indexDestino < 0)
                {
                    Console.WriteLine($"Conta de destino {nomeDestino} não encontrada.");
                }
            }
        }

        public void ConsultarSaldo(string nome)
        {
            int index = contas.IndexOf(nome);
            if (index >= 0)
            {
                Console.WriteLine($"Saldo da conta {nome}: {saldos[index]}.");
            }
            else
            {
                Console.WriteLine($"Conta {nome} não encontrada.");
            }
        }

        public void ConsultarExtrato(string nome)
        {
            int index = contas.IndexOf(nome);
            if (index >= 0)
            {
                Console.WriteLine($"Extrato da conta {nome}:");
                foreach (var transacao in extratos[index])
                {
                    Console.WriteLine(transacao);
                }
            }
            else
            {
                Console.WriteLine($"Conta {nome} não encontrada.");
            }
        }
    }

}
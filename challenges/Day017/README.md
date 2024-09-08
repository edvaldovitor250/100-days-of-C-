# Day 17

## Desafio:

Crie uma classe em C# para representar um sistema de gestão de funcionários com operações de adicionar, remover e atualizar informações dos funcionários.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

namespace Day017
{
    public class GestaoFuncionarios
   {
        public List<string> nomeFunc;
        public List<int> salarioFunc;
        public List<int> idadeFunc;

        public GestaoFuncionarios() 
        {
            nomeFunc = new List<string>();
            salarioFunc = new List<int>();
            idadeFunc = new List<int>();
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("Nomes:");
            foreach (string nomes in nomeFunc)
            {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("\nSalarios:");
            foreach (int salarios in salarioFunc)
            {
                Console.WriteLine(salarios);
            }

            Console.WriteLine("\nIdades:");
            foreach (int idades in idadeFunc)
            {
                Console.WriteLine(idades);
            }

            Console.WriteLine("\n");
        }

        public void AdicionarFuncionario(string nome, int salario, int idade)
        {
            nomeFunc.Add(nome);
            salarioFunc.Add(salario);
            idadeFunc.Add(idade);
        }

        public void RemoverFuncionario(string nome)
        {
            int index = nomeFunc.IndexOf(nome);
            if (index != -1)
            {
                nomeFunc.RemoveAt(index);
                salarioFunc.RemoveAt(index);
                idadeFunc.RemoveAt(index);
                Console.WriteLine($"Funcionario {nome} removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Funcionario {nome} não encontrado!");
            }
        }

        public void AtualizarFuncionario(string nome, int novoSalario, int novaIdade)
        {
            int index = nomeFunc.IndexOf(nome);
            if (index != -1)
            {
                salarioFunc[index] = novoSalario;
                idadeFunc[index] = novaIdade;
                Console.WriteLine($"Salario e idade do funcionario {nome} atualizados com sucesso!");
            }
            else
            {
                Console.WriteLine($"Funcionario {nome} não encontrado!");
            }
        }
    }
    
}
using Day017;

GestaoFuncionarios gestao = new GestaoFuncionarios();

            gestao.AdicionarFuncionario("João", 3000, 30);
            gestao.AdicionarFuncionario("Maria", 4000, 28);
            gestao.AdicionarFuncionario("Pedro", 3500, 35);

            gestao.ListarFuncionarios();
            
            gestao.AtualizarFuncionario("Maria", 4500, 29);

            gestao.RemoverFuncionario("João");
            gestao.ListarFuncionarios();
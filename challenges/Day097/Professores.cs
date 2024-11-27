using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day097
{
    public class Professores
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Professores(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
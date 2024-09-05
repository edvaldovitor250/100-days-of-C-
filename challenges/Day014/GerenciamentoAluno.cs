using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day014
{
    public class GerenciamentoAluno
    {
        List<string> aluno = new List<string>();
        List<string> materia = new List<string>();


        public GerenciamentoAluno()
        {
            aluno = new List<string>();
            materia = new List<string>();
        }

        public void adicionarDados(string alunos, string materias)
        {
            aluno.Add(alunos);
            materia.Add(materias);
            Console.WriteLine("Aluno adicionado: " + alunos);
            Console.WriteLine("Matéria adicionada: " + materias);
            
            Console.WriteLine("\nLista completa de alunos:");
            foreach (string al in aluno)
            {
                Console.WriteLine("" + al);
            }
            Console.WriteLine("\nLista completa de matérias:");

            foreach (string ma in materia)
            {
                Console.WriteLine("" + ma);
            }
        }

        public void remover(string alunos, int materias){
            aluno.Remove(alunos);
            materia.RemoveAt(materias);

            Console.WriteLine("\nLista completa de alunos:");
            foreach (string al in aluno)
            {
                Console.WriteLine("" + al);
            }
            Console.WriteLine("\nLista completa de matérias:");

            foreach (string ma in materia)
            {
                Console.WriteLine("" + ma);
            }
        }

        public void atualizarAluno(string alunos, int materias){
            aluno[materias] = alunos;
            Console.WriteLine("");

        }


    }
}
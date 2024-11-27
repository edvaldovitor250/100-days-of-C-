public class GerenciamentoIdiomas
{
    List<Alunos> alunos = new List<Alunos>();
    List<Professores> professores = new List<Professores>();
    List<Turmas> turmas = new List<Turmas>();

    public void Adicionar(Object obj)
    {
        if(obj is Alunos)
        {
            alunos.Add((Alunos)obj);
        }
        else if(obj is Professores)
        {
            professores.Add((Professores)obj);
        }
        else if(obj is Turmas)
        {
            turmas.Add((Turmas)obj);
        }
    }

    public void Remover(Object obj)
    {
        if(obj is Alunos)
        {
            alunos.Remove((Alunos)obj);
        }
        else if(obj is Professores)
        {
            professores.Remove((Professores)obj);
        }
        else if(obj is Turmas)
        {
            turmas.Remove((Turmas)obj);
        }
    }

    public void Atualizar(Object obj)
    {
        if(obj is Alunos)
        {
            alunos[alunos.IndexOf((Alunos)obj)] = (Alunos)obj;
        }
        else if(obj is Professores)
        {
            professores[professores.IndexOf((Professores)obj)] = (Professores)obj;
        }
        else if(obj is Turmas)
        {
            turmas[turmas.IndexOf((Turmas)obj)] = (Turmas)obj;
        }
    }

    public void Listar()
    {
        Console.WriteLine("Alunos:");
        foreach(var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("Professores:");
        foreach(var professor in professores)
        {
            Console.WriteLine(professor);
        }

        Console.WriteLine("Turmas:");
        foreach(var turma in turmas)
        {
            Console.WriteLine(turma);
        }
    }

    
}
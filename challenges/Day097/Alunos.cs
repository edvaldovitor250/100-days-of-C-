public class Alunos
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Alunos(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    
    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
    
}
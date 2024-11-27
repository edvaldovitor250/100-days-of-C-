public class Turmas
{
    public string Nome { get; set; }
    public int serie { get; set; }
    public string turno { get; set; }

    public Turmas(string nome, int serie, string turno)
    {
        this.Nome = nome;
        this.serie = serie;
        this.turno = turno;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Série: {serie}, Turno: {turno}";
    }

    


}
public class Disciplina
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Disciplina(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("Nome da disciplina não pode ser vazio.");
        Nome = nome;
    }
}

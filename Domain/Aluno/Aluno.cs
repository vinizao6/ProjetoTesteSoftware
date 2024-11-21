namespace ProjetoTeste.Domain.Aluno
public class Aluno
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Matricula { get; private set; }

    public Aluno(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public void AtualizarNome(string novoNome)
    {
        if (string.IsNullOrWhiteSpace(novoNome) || novoNome.Length < 3)
            throw new ArgumentException("Nome deve ter pelo menos 3 caracteres.");

        Nome = novoNome;    
    }
}

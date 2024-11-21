public class Nota
{
    public int Id { get; private set; }
    public int AlunoId { get; private set; }
    public int DisciplinaId { get; private set; }
    public double Valor { get; private set; }
    public DateTime DataRegistro { get; private set; }

    public Nota(int alunoId, int disciplinaId, double valor)
    {
        AlunoId = alunoId;
        DisciplinaId = disciplinaId;
        RegistrarNota(valor);
    }

    public void RegistrarNota(double valor)
    {
        if (valor < 0 || valor > 10)
            throw new ArgumentException("Nota deve estar entre 0 e 10.");
        Valor = valor;
        DataRegistro = DateTime.Now;
    }
}

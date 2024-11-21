namespace Application.DTOs
{
    public class AlunoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int QuantidadeNotas { get; set; }
    }
}

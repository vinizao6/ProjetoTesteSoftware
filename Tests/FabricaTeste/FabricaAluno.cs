using Bogus;
using ProjetoTeste.Domain.Aluno;

namespace ProjetoTeste.Tests.FabricaTeste
{
    public static class FabricaAluno
    {
        private static Faker<Aluno> AlunoValido()
        {
            return new Faker<Aluno>()
                .RuleFor(a => a.Nome, f => f.Person.FullName)
                .RuleFor(a => a.Email, f => f.Internet.Email())
                .RuleFor(a => a.Matricula, f => f.Random.Int(10000, 99999).ToString())
                .RuleFor(a => a.DataNascimento, f => f.Date.Past(20, DateTime.Now.AddYears(-10)));
        }

        public static Aluno Valido()
        {
            return AlunoValido().Generate();
        }

        public static Aluno NomeInvalido()
        {
            var aluno = AlunoValido();
            aluno.RuleFor(a => a.Nome, string.Empty);

            return aluno.Generate();
        }

        public static Aluno EmailInvalido()
        {
            var aluno = AlunoValido();
            aluno.RuleFor(a => a.Email, "email_invalido");

            return aluno.Generate();
        }

        public static Aluno MatriculaInvalida()
        {
            var aluno = AlunoValido();
            aluno.RuleFor(a => a.Matricula, string.Empty);

            return aluno.Generate();
        }
    }
}

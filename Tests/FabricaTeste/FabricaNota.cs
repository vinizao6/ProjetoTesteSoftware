using Bogus;
using ProjetoTeste.Domain.Nota;

namespace ProjetoTeste.Tests.FabricaTeste
{
    public static class FabricaNota
    {
        private static Faker<Nota> NotaValida()
        {
            return new Faker<Nota>()
                .RuleFor(n => n.Valor, f => f.Random.Decimal(0, 10))
                .RuleFor(n => n.Descricao, f => f.Lorem.Sentence());
        }

        public static Nota Valida()
        {
            return NotaValida().Generate();
        }

        public static Nota ValorInvalido()
        {
            var nota = NotaValida();
            nota.RuleFor(n => n.Valor, -1);

            return nota.Generate();
        }

        public static Nota DescricaoInvalida()
        {
            var nota = NotaValida();
            nota.RuleFor(n => n.Descricao, string.Empty);

            return nota.Generate();
        }
    }
}

using Bogus;
using ProjetoTeste.Domain.Nota;

namespace ProjetoTeste.Tests.FabricaTeste.FabricaNota;

    public static class FabricaNota
    {
        private static Faker<Nota> NotaValida()
{
    return new Faker<Nota>()
        .RuleFor(n => n.Titulo, f => f.Lorem.Sentence())
        .RuleFor(n => n.Conteudo, f => f.Lorem.Paragraph())
        .RuleFor(n => n.Importancia, f => f.Random.Int(1, 5));
}

public static Nota Valida()
{
    return NotaValida().Generate();
}

public static Nota InvalidaSemTitulo()
{
    var nota = NotaValida();
    nota.RuleFor(n => n.Titulo, string.Empty);
    return nota.Generate();
}

public static Nota InvalidaSemConteudo()
{
    var nota = NotaValida();
    nota.RuleFor(n => n.Conteudo, string.Empty);
    return nota.Generate();
}

public static Nota InvalidaComImportanciaForaDoLimite()
{
    var nota = NotaValida();
    nota.RuleFor(n => n.Importancia, 10); // Definindo uma importância inválida
    return nota.Generate();
}
    }


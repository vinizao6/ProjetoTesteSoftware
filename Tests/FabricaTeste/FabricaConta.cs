using Bogus;
using ProjetoTeste.Domain.Conta;



namespace ProjetoTeste.Tests.FabricaTeste
{

public static class FabricaConta
{
    private static Faker<Contas> ValidAccount()
    {
        return new Faker<Contas>()
                   .RuleFor(u => u.Email, f => f.Internet.Email())
                   .RuleFor(e => e.Nomeusuario, e => e.Internet.UserName())
                   .RuleFor(e => e.Senha, e => e.Lorem.Word());
    }

    public static Contas Valid()
    {
        return ValidAccount().Generate();
    }

    public static Contas InvalidUsername()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Nomeusuario, string.Empty);

        return valid.Generate();
    }

    public static Contas InvalidEmail()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Email, string.Empty);

        return valid.Generate();
    }

    public static Contas InvalidPassword()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Senha, string.Empty);

        return valid.Generate();
    }
}
}
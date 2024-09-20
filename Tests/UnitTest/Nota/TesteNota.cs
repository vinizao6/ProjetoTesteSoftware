using NUnit.Framework;
using ProjetoTeste.Domain.Nota;
using ProjetoTeste.Tests.FabricaTeste.FabricaNota;
using FluentAssertions;

namespace ProjetoTeste.Tests
{
    public class TesteNota
    {
        [Test]
        public void Deve_Criar_Nota_Valida()
        {
            var nota = FabricaNota.Valida();
            nota.Titulo.Should().NotBeNullOrWhiteSpace();
            nota.Conteudo.Should().NotBeNullOrWhiteSpace();
            nota.Importancia.Should().BeInRange(1, 5);
        }

        [Test]
        public void Deve_Falhar_Nota_Sem_Titulo()
        {
            var nota = FabricaNota.InvalidaSemTitulo();
            nota.Titulo.Should().BeEmpty();
        }

        [Test]
        public void Deve_Falhar_Nota_Sem_Conteudo()
        {
            var nota = FabricaNota.InvalidaSemConteudo();
            nota.Conteudo.Should().BeEmpty();
        }

        [Test]
        public void Deve_Falhar_Nota_Com_Importancia_Invalida()
        {
         
            Action act = () => FabricaNota.InvalidaComImportanciaForaDoLimite();
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Deve_Ranquear_Nota_Corretamente()
        {
            var nota = FabricaNota.Valida();
            nota.RankearImportancia(4);
            nota.Importancia.Should().Be(4);
        }
    }
}

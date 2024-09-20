using NUnit.Framework;
using ProjetoTeste.Domain.Conta; 
using ProjetoTeste.Tests.FabricaTeste;
using FluentAssertions;

namespace ProjetoTeste.Tests;
   public class TesteConta
    {
        [Test]
        public void Deve_Criar_Conta_Valida()
        {
            
            var conta = FabricaConta.Valid();

            
            conta.Nomeusuario.Should().NotBeNullOrWhiteSpace();
            conta.Email.Should().NotBeNullOrWhiteSpace();
            conta.Senha.Should().NotBeNullOrWhiteSpace();
        }

        [Test]
        public void Deve_Falhar_Conta_Com_Username_Invalido()
        {
            
            var conta = FabricaConta.InvalidUsername();

           
            conta.Nomeusuario.Should().BeEmpty();
        }

        [Test]
        public void Deve_Falhar_Conta_Com_Email_Invalido()
        {
            
            var conta = FabricaConta.InvalidEmail();

            
            conta.Email.Should().BeEmpty();
        }

        [Test]
        public void Deve_Falhar_Conta_Com_Senha_Invalida()
        {
           
            var conta = FabricaConta.InvalidPassword();

           
            conta.Senha.Should().BeEmpty();
        }
    }


  




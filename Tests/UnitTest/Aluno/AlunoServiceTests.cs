using Application.DTOs;
using Application.Services;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Tests
{
    public class AlunoServiceTests
    {
        private AlunoService _service;
        private AppDbContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            _context = new AppDbContext(options);
            _service = new AlunoService(_context);
        }

        [Test]
        public async Task DeveAdicionarAlunoComSucesso()
        {
            var alunoDto = new AlunoDTO
            {
                Nome = "João Silva",
                DataNascimento = new DateTime(2000, 1, 1)
            };

            await _service.Adicionar(alunoDto);

            var alunos = await _service.ObterTodos();

            Assert.AreEqual(1, alunos.Count());
            Assert.AreEqual("João Silva", alunos.First().Nome);
        }

        [Test]
        public void DeveLancarExcecao_QuandoAlunoNaoEncontrado()
        {
            Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await _service.ObterPorId(Guid.NewGuid());
            });
        }
    }
}

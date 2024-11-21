using Application.DTOs;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class AlunoService
    {
        private readonly AppDbContext _context;

        public AlunoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AlunoDTO>> ObterTodos()
        {
            return await _context.Alunos
                .Select(a => new AlunoDTO
                {
                    Id = a.Id,
                    Nome = a.Nome,
                    DataNascimento = a.DataNascimento,
                    QuantidadeNotas = a.Notas.Count
                })
                .ToListAsync();
        }

        public async Task<AlunoDTO> ObterPorId(Guid id)
        {
            var aluno = await _context.Alunos
                .Include(a => a.Notas)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (aluno == null)
                throw new ArgumentException("Aluno não encontrado.");

            return new AlunoDTO
            {
                Id = aluno.Id,
                Nome = aluno.Nome,
                DataNascimento = aluno.DataNascimento,
                QuantidadeNotas = aluno.Notas.Count
            };
        }

        public async Task Adicionar(AlunoDTO alunoDto)
        {
            var aluno = new Aluno(alunoDto.Nome, alunoDto.DataNascimento);

            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
        }
    }
}

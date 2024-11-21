using Application.DTOs;
using FluentValidation;

namespace Application.Validators
{
    public class AlunoValidator : AbstractValidator<AlunoDTO>
    {
        public AlunoValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .Length(3, 100).WithMessage("O nome deve ter entre 3 e 100 caracteres.");

            RuleFor(a => a.DataNascimento)
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser no passado.");
        }
    }
}

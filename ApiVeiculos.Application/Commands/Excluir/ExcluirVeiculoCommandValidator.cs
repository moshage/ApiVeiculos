using FluentValidation;

namespace ApiVeiculos.Application.Commands.Excluir
{
    public class ExcluirVeiculoCommandValidator : AbstractValidator<ExcluirVeiculoCommand>
    {
        public ExcluirVeiculoCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("O id do veículo é obrigatório");
        }
    }
}

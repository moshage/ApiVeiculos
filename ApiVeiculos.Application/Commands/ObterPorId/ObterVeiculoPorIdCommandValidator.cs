using FluentValidation;

namespace ApiVeiculos.Application.Commands.ObterPorId
{
    public class ObterVeiculoPorIdCommandValidator : AbstractValidator<ObterVeiculoPorIdCommand>
    {
        public ObterVeiculoPorIdCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("O id do veículo é obrigatório.");
        }
    }
}

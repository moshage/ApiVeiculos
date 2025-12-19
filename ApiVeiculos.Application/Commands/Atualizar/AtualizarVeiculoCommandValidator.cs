using FluentValidation;

namespace ApiVeiculos.Application.Commands.Atualizar
{
    public class AtualizarVeiculoCommandValidator : AbstractValidator<AtualizarVeiculoCommand>
    {
        public AtualizarVeiculoCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("O id do veículo é obrigatório.");
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("A descrição do veículo é obrigatória.");
            RuleFor(x => x.Modelo).NotEmpty().WithMessage("O modelo do veículo é Obrigatório.");
            RuleFor(x => x.Marca).IsInEnum().WithMessage("A marca do veículo é obrigatória");
        }
    }
}

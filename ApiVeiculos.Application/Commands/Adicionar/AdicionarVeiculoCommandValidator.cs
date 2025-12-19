using FluentValidation;

namespace ApiVeiculos.Application.Commands.Adicionar
{
    public class AdicionarVeiculoCommandValidator : AbstractValidator<AdicionarVeiculoCommand>
    {
        public AdicionarVeiculoCommandValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("A descrição do veículo é obrigatória.");
            RuleFor(x => x.Modelo).NotEmpty().WithMessage("O modelo do veículo é obrigatório.");
            RuleFor(x => x.Marca).IsInEnum().WithMessage("A marca do veículo é inválida.");
            RuleFor(x => x.Valor).GreaterThan(0).When(x => x.Valor.HasValue).WithMessage("O valor deve ser maior que zero.");
        }
    }
}

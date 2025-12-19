using MediatR;

namespace ApiVeiculos.Application.Commands.Excluir
{
    public record ExcluirVeiculoCommand(Guid Id) : IRequest;
}

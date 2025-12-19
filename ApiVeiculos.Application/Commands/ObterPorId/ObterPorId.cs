using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.ObterPorId
{
    public record ObterVeiculoPorIdCommand(Guid Id) : IRequest<Veiculo?>;
}

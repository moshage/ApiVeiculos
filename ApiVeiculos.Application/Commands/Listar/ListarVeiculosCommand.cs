using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.Listar
{
    public record ListarVeiculosCommand : IRequest<List<Veiculo>>;
}

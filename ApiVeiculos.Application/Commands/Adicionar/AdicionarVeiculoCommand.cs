using ApiVeiculos.Domain.Enumeradores;
using MediatR;

namespace ApiVeiculos.Application.Commands.Adicionar
{
    public record AdicionarVeiculoCommand(
        string Descricao,
        Marca Marca,
        string Modelo,
        string? Opcionais,
        decimal? Valor
        ) : IRequest<Guid>;
}

using ApiVeiculos.Domain.Enumeradores;
using MediatR;

namespace ApiVeiculos.Application.Commands.Atualizar
{
    public record AtualizarVeiculoCommand(
        Guid Id,
        string Descricao,
        Marca Marca,
        string Modelo,
        string? Opcionais,
        decimal? Valor
        ) : IRequest;
}

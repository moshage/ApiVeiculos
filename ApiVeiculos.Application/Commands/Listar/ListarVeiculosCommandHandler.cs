using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.Listar
{
    public class ListarVeiculosCommandHandler : IRequestHandler<ListarVeiculosCommand, List<Veiculo>>
    {
        private readonly IVeiculoService _service;

        public ListarVeiculosCommandHandler(IVeiculoService service)
        {
            _service = service;
        }

        public async Task<List<Veiculo>> Handle(ListarVeiculosCommand request, CancellationToken cancellationToken)
        {
            return await _service.ListarAsync();
        }
    }
}

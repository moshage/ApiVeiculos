using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.ObterPorId
{
    public class ObterVeiculoPorIdCommandHandler : IRequestHandler<ObterVeiculoPorIdCommand, Veiculo?>
    {
        private readonly IVeiculoService _service;

        public ObterVeiculoPorIdCommandHandler(IVeiculoService service)
        {
            _service = service;
        }

        public async Task<Veiculo?> Handle(ObterVeiculoPorIdCommand request, CancellationToken cancellationToken)
        {
            return await _service.ObterPorIdAsync(request.Id);
        }
    }
}

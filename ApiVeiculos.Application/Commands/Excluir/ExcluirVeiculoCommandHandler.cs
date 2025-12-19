using ApiVeiculos.Application.VeiculoService.Interfaces;
using MediatR;

namespace ApiVeiculos.Application.Commands.Excluir
{
    public class ExcluirVeiculoCommandHandler : IRequestHandler<ExcluirVeiculoCommand>
    {
        private readonly IVeiculoService _service;

        public ExcluirVeiculoCommandHandler(IVeiculoService service)
        {
            _service = service;
        }

        public async Task Handle(ExcluirVeiculoCommand request, CancellationToken cancellationToken)
        {
            await _service.ExcluirAsync(request.Id);
        }
    }
}

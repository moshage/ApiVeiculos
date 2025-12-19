using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.Atualizar
{
    public class AtualizarVeiculoCommandHandler : IRequestHandler<AtualizarVeiculoCommand>
    {
        private readonly IVeiculoService _service;

        public AtualizarVeiculoCommandHandler(IVeiculoService service)
        {
            _service = service;
        }

        public async Task Handle(AtualizarVeiculoCommand request, CancellationToken cancellationToken)
        {
            var veiculo = new Veiculo
            {
                Id = request.Id,
                Descricao = request.Descricao,
                Marca = request.Marca,
                Modelo = request.Modelo,
                Opcionais = request.Opcionais,
                Valor = request.Valor
            };


            await _service.AtualizarAsync(veiculo);
        }
    }
}

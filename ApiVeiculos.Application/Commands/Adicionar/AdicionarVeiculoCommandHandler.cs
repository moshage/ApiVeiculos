using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Entidades;
using MediatR;

namespace ApiVeiculos.Application.Commands.Adicionar
{
    public class AdicionarVeiculoCommandHandler : IRequestHandler<AdicionarVeiculoCommand, Guid>
    {
        private readonly IVeiculoService _service;

        public AdicionarVeiculoCommandHandler(IVeiculoService service)
        {
            _service = service;
        }

        public async Task<Guid> Handle(AdicionarVeiculoCommand request, CancellationToken cancellationToken)
        {
            var veiculo = new Veiculo
            {
                Descricao = request.Descricao,
                Marca = request.Marca,
                Modelo = request.Modelo,
                Opcionais = request.Opcionais,
                Valor = request.Valor
            };


            return await _service.AdicionarAsync(veiculo);
        }
    }
}

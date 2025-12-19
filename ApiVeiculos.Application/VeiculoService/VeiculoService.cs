using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Entidades;
using ApiVeiculos.Domain.Interfaces.Repositories;

namespace ApiVeiculos.Application.VeiculoService
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> AdicionarAsync(Veiculo veiculo)
        {
            veiculo.Id = Guid.NewGuid();
            await _repository.AdicionarAsync(veiculo);
            return veiculo.Id;
        }

        public async Task AtualizarAsync(Veiculo veiculo)
        {
            await _repository.AtualizarAsync(veiculo);
        }

        public async Task ExcluirAsync(Guid id)
        {
            await _repository.ExcluirAsync(id);
        }
        
        public async Task<Veiculo?> ObterPorIdAsync(Guid id)
        {
            return await _repository.ObterPorIdAsync(id);
        }
        
        public async Task<List<Veiculo>> ListarAsync()
        {
            return await _repository.ListarAsync();
        }
    }
}

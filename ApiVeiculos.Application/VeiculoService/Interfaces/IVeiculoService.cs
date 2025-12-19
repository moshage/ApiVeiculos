using ApiVeiculos.Domain.Entidades;

namespace ApiVeiculos.Application.VeiculoService.Interfaces
{
    public interface IVeiculoService
    {
        Task<Guid> AdicionarAsync(Veiculo veiculo);
        Task AtualizarAsync(Veiculo veiculo);
        Task ExcluirAsync(Guid id);
        Task<Veiculo?> ObterPorIdAsync(Guid id);
        Task<List<Veiculo>> ListarAsync();
    }
}

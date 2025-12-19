using ApiVeiculos.Domain.Entidades;

namespace ApiVeiculos.Domain.Interfaces.Repositories
{
    public interface IVeiculoRepository
    {
        Task AdicionarAsync(Veiculo veiculo);
        Task AtualizarAsync(Veiculo veiculo);
        Task ExcluirAsync(Guid id);
        Task<Veiculo?> ObterPorIdAsync(Guid id);
        Task<List<Veiculo>> ListarAsync();
    }
}

using ApiVeiculos.Domain.Entidades;
using ApiVeiculos.Domain.Interfaces.Repositories;
using ApiVeiculos.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly VeiculoDbContext _context;

        public VeiculoRepository(VeiculoDbContext context)
        {
            _context = context;
        }
        public async Task AdicionarAsync(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(Guid id)
        {
            var veiculo = await ObterPorIdAsync(id);
            if (veiculo is null)
                throw new KeyNotFoundException("Veículo não encontrado");

            _context.Veiculos.Remove(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task<Veiculo?> ObterPorIdAsync(Guid id)
        {
            return await _context.Veiculos.FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<List<Veiculo>> ListarAsync()
        {
            return await _context.Veiculos.ToListAsync();
        }
    }
}

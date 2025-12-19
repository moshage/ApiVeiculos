using ApiVeiculos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiVeiculos.Infrastructure.Context
{
    public class VeiculoDbContext : DbContext
    {
        public VeiculoDbContext(DbContextOptions<VeiculoDbContext> options)
        : base(options) { }


        public DbSet<Veiculo> Veiculos => Set<Veiculo>();
    }
}

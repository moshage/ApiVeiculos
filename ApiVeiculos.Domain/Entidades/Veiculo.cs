using ApiVeiculos.Domain.Enumeradores;

namespace ApiVeiculos.Domain.Entidades
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public Marca Marca { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string? Opcionais { get; set; }
        public decimal? Valor { get; set; }
    }
}

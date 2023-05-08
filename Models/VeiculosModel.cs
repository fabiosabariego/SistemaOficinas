namespace SistemaOficinas.Models
{
    public class VeiculosModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public string? Placa { get; set; }
        public int Km { get; set; }
        public string? Obs { get; set; }
    }
}

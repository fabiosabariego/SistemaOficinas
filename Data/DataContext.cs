using Microsoft.EntityFrameworkCore;
using SistemaOficinas.Models;

namespace SistemaOficinas.Data
{
    public class DataContext : DbContext
    {
        public DbSet<FabricanteModel> Fabricantes { get; set; } // Declarando a Model que tera ligacao com o Banco de Dados

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected DataContext()
        {

        }
    }
}

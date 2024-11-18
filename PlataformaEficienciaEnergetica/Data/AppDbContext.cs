using Microsoft.EntityFrameworkCore;
using PlataformaEficienciaEnergetica.Models;

namespace PlataformaEficienciaEnergetica.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Predio> Predios { get; set; } // Adiciona DbSet para a tabela Predio
    }
}

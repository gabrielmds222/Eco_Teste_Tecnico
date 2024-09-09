using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {
        }
        public DbSet<MensageiroModel> Mensageiros { get; set; }
        public DbSet<ContribuinteModel> Contribuintes { get; set; }
        public DbSet<TipoPagamentoModel> TipoPagamentos { get; set; }
        public DbSet<MovimentoDiarioModel> MovimentoDiario { get; set; }
        public DbSet<ContribuicaoModel> Contribuicao { get; set; }

    }
}

using EscolaAtiva.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EscolaAtiva.API.Persistence
{
    public class EscolaAtivaContext : DbContext
    {
        public EscolaAtivaContext(DbContextOptions<EscolaAtivaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> JobVacancies { get; set; }
        public DbSet<Atividade> JobApplications { get; set; }
    }
}
using EscolaAtiva.API.Entities;
using EscolaAtiva.API.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaAtiva.API.Persistence
{
    public class EscolaAtivaContext : DbContext
    {
        public EscolaAtivaContext(DbContextOptions<EscolaAtivaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>(e => {
                e.HasKey(x => x.IdUsuario);

                e.HasMany(x => x.Atividades)
                    .WithOne()
                    .HasForeignKey(x => x.IdAutor)
                    .OnDelete(DeleteBehavior.Restrict);
                
                e.Property(x => x.Genero)
                    .HasConversion(new EnumToStringConverter<EGenero>());
            });

            builder.Entity<Atividade>(e => {
                e.HasKey(x => x.IdAtividade);

                e.Property(x => x.Disciplina)
                    .HasConversion(new EnumToStringConverter<EDisciplina>());
            });
        }
    }
}
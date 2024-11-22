namespace JudoAPI.Data;


using Microsoft.EntityFrameworkCore;
using JudoAPI.Models;


public class JudoContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<AlunoAula> AlunoAulas { get; set; }

    public JudoContext(DbContextOptions<JudoContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlunoAula>()
            .HasKey(aa => new { aa.AlunoId, aa.AulaId });
    }
}


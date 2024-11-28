namespace JudoAPI.Data;


using Microsoft.EntityFrameworkCore;
using JudoAPI.Models;


public class JudoContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Aluno> AlunoAulas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public object Alunos { get; internal set; }

    public JudoContext(DbContextOptions<JudoContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=judodb");
    }
}


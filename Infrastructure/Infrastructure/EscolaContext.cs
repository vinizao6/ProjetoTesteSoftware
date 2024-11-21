public class EscolaContext : DbContext
{
    public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Nota> Notas { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
        modelBuilder.Entity<Nota>().HasKey(n => n.Id);
        modelBuilder.Entity<Disciplina>().HasKey(d => d.Id);

        modelBuilder.Entity<Nota>()
            .HasOne<Aluno>()
            .WithMany()
            .HasForeignKey(n => n.AlunoId);

        modelBuilder.Entity<Nota>()
            .HasOne<Disciplina>()
            .WithMany()
            .HasForeignKey(n => n.DisciplinaId);
    }
}
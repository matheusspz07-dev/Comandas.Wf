
using Comandas.Wf.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Comandas.Wf;

public class ComandasDbContext:DbContext
{
    public ComandasDbContext()
    {
        
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
    public DbSet<CardapioItem> CardapioItems { get; set; }
    public DbSet<Comanda> Comandas { get; set; }
    public DbSet<ComandaItem> ComandaItems { get; set; }
    public DbSet<Mesa> Mesas { get; set; }
    public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
    public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComandasDb;Username=postgres;Password=snowmille;");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mesa>(m =>
        {
            m.ToTable("Mesa");
        });

        modelBuilder.Entity<Usuario>(u =>
        {
            u.ToTable("Usuario");
            u.Property(u => u.Nome).HasColumnType("varchar(100)");
            u.Property(u => u.Senha).HasColumnType("varchar(100)");
            u.Property(u => u.Email).HasColumnType("varchar(100)");
        });

        modelBuilder.Entity<PerfilUsuario>(pu =>
        {
            pu.ToTable("PerfilUsuario");
            pu.Property(pu => pu.Descricao).HasColumnType("varchar(100)");
        });

        modelBuilder.Entity<CardapioItem>(ci =>
        {
            ci.ToTable("CardapioItem");
            ci.Property(ci => ci.Titulo).HasColumnType("varchar(200)");
            ci.Property(ci => ci.Descricao).HasColumnType("varchar(400)");
        });

        modelBuilder.Entity<Comanda>(c =>
        {
            c.ToTable("Comanda");
            c.Property(c => c.NomeCliente).HasColumnType("varchar(100)");
        });

        modelBuilder.Entity<ComandaItem>(ci =>
        {
            ci.ToTable("ComandaItem");
        });

        modelBuilder.Entity<PedidoCozinha>(pc =>
        {
            pc.ToTable("PedidoCozinha");
        });

        modelBuilder.Entity<PedidoCozinhaItem>(pc =>
        {
            pc.ToTable("PedidoCozinhaItem");
        });

        modelBuilder.Entity<Comanda>()
            .HasMany<ComandaItem>()
            .WithOne(ci => ci.Comanda)
            .HasForeignKey(ci => ci.ComandaId);

        modelBuilder.Entity<ComandaItem>()
            .HasOne(ci => ci.Comanda)
            .WithMany(c => c.ComandaItens)
            .HasForeignKey(ci => ci.ComandaId);

        modelBuilder.Entity<ComandaItem>()
            .HasOne(ci => ci.CardapioItem)
            .WithMany()
            .HasForeignKey(ci => ci.CardapioItemId);

        modelBuilder.Entity<PedidoCozinha>()
            .HasMany<PedidoCozinhaItem>()
            .WithOne(pci => pci.PedidoCozinha)
            .HasForeignKey(pci => pci.PedidoCozinhaId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PedidoCozinhaItem>()
            .HasOne(pci => pci.PedidoCozinha)
            .WithMany(pc => pc.PedidoCozinhaItems)
            .HasForeignKey(pci => pci.PedidoCozinhaId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<PedidoCozinhaItem>()
            .HasOne(pci => pci.ComandaItem)
            .WithMany()
            .HasForeignKey(pci => pci.ComandaItemId);

        base.OnModelCreating(modelBuilder);
    }
}

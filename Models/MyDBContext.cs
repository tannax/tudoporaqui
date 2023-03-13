using Microsoft.EntityFrameworkCore;
using atvIII.Models;

namespace atvIII.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<AssuntoFC> Assuntos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssuntoFC>(entity =>
            {
                entity.HasIndex(e => e.telefone)
                      .HasName("telefone");

                entity.Property(e => e.idAssuntofaleConosco).HasColumnName("idAssuntofaleConosco")
                      .ValueGeneratedOnAdd();
            });
        }
    }
}

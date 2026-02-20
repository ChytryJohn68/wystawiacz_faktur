using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace wystawiacz_faktur.repository
{
    public class kontrahentContext : DbContext
    {
        public DbSet<kontrahent> kontrahent { get; set; }

        public DbSet<faktura_poz> faktura_poz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=mydb;user=localhost;password=DBServer12");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.id_nabywca);
                entity.Property(e => e.nazwa).IsRequired();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                entity.HasOne(d => d.Publisher)
                  .WithMany(p => p.Books);
            });
        }
    }
}

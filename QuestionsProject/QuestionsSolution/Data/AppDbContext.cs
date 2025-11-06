using Microsoft.EntityFrameworkCore;
using QuestionsSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsSolution.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-AF6EDUF\\SQLEXPRESSS;" +
                "Database=Teste_Login;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = modelBuilder.Entity<User>();

            user.ToTable("Users"); // garante o nome correto da tabela

            user.HasKey(u => u.UserId);

            user.Property(u => u.UserLogin)
                .IsRequired()
                .HasMaxLength(50);

            user.Property(u => u.UserPassword)
                .IsRequired()
                .HasMaxLength(250);

            user.Property(u => u.Salt)
                .IsRequired()
                .HasMaxLength(15);

            base.OnModelCreating(modelBuilder);
        }
    }
}

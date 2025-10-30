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
    }
}

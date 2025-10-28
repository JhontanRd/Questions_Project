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
        // Vou precisar ligar o banco ao projeto para testar 

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Vou Precisar mudar a connection string para a do meu banco 
            optionsBuilder.UseSqlServer(
                "Server=localhost;" +
                "Database=TesteEFDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;"
            );
        }
    }
}

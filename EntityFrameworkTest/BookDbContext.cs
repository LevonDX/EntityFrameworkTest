using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    internal class BookDbContext : DbContext
    {
        const string connectionString =
            "Data Source = localhost; Initial Catalog = BookStoreDbEf; Integrated Security = True; TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

            this.Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}

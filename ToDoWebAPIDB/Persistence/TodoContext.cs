using Microsoft.EntityFrameworkCore;
using TodoWEBAPIDB.Configuration;
using TodoWEBAPIDB.Models;

namespace TodoWEBAPIDB.Persistence
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=Todos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
        }
    }
}
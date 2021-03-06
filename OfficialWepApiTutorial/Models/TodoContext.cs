using Microsoft.EntityFrameworkCore;
using OfficialWepApiTutorial.Models;

namespace TodoApi.Models{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
            
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoWEBAPIDB.Models;

namespace TodoWEBAPIDB.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todos.db");
          //  builder.Property(s => s.IsCompleted).IsRequired(false);
            builder.Property(s => s.IsCompleted).HasDefaultValue(true);
            builder.HasData(
                new Todo
                {
                    UserId = 3,
                    Title = "Be happy",
                    IsCompleted = false
                }, new Todo
                {
                    UserId = 4,
                    Title = "Found 3 4 billion companies",
                    IsCompleted = false
                }, new Todo
                {
                    UserId = 5,
                    Title = "Build the future Facebook",
                    IsCompleted = false
                }
                , new Todo
                {
                    UserId = 6,
                    Title = "Demonstrate Viete formulas ",
                    IsCompleted = false
                }
                , new Todo
                {
                    UserId = 6,
                    Title = "Push up exercise",
                    IsCompleted = false
                }
                , new Todo
                {
                    UserId = 5,
                    Title = "Do homework",
                    IsCompleted = false
                }
                , new Todo
                {
                    UserId = 4,
                    Title = "Go out",
                    IsCompleted = false
                }
            );
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TODO_Blazer.Models;
namespace TODO_Blazer.DataContext
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }

        public DbSet<Todo>Todo_Blaze {get; set;}
    }
}
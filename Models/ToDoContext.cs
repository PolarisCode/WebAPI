using Microsoft.EntityFrameworkCore;

namespace ToDo_API.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options):base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
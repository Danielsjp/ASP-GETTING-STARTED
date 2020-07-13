using Microsoft.EntityFrameworkCore;
using Intro_ASP.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> TodoItems { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.Domain
{
    public class ToDoListDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TaskApp> Tasks { get; set; }

        public ToDoListDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace todo.Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
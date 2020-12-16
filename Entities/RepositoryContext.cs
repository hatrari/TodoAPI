using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Entities
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
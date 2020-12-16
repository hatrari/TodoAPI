using TodoAPI.Entities;
using TodoAPI.Interfaces;

namespace TodoAPI.Repositories
{
    public class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        public ToDoRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
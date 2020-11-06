using todo.Entities;
using todo.Interfaces;

namespace todo.Repositories
{
    public class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        public ToDoRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
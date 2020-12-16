using TodoAPI.Interfaces;
using TodoAPI.Entities;

namespace TodoAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private RepositoryContext _repoContext;
        private IToDoRepository _todo;

        public IToDoRepository ToDo {
            get {
                if(_todo == null)
                {
                    _todo = new ToDoRepository(_repoContext);
                }

                return _todo;
            }
        }

        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
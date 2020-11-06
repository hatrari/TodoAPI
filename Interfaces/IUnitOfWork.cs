namespace todo.Interfaces
{
    public interface IUnitOfWork
    {
        IToDoRepository ToDo { get; }
        void Save();
    }
}
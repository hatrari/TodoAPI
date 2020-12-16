namespace TodoAPI.Interfaces
{
    public interface IUnitOfWork
    {
        IToDoRepository ToDo { get; }
        void Save();
    }
}
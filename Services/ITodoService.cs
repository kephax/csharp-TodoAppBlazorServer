using TodoAppBlazorServer.Data;

namespace TodoAppBlazorServer.Services
{
    public abstract class ITodoService
    {
        public abstract void Add(TodoItem item);
        public abstract void Delete(TodoItem item);
        public abstract IEnumerable<TodoItem> GetAll();

        public abstract void Complete(TodoItem item);
        public abstract void Uncomplete(TodoItem item);
        
    }
}

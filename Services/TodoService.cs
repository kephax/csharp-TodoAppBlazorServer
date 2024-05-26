using TodoAppBlazorServer.Data;

namespace TodoAppBlazorServer.Services
{
    public class TodoService :ITodoService
    {
        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>()
            {
                new TodoItem("Wash clothes"),
                new TodoItem("Clean Desk")
            };


        }

        public override void Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        public override void Delete(TodoItem item)
        {
            _todoItems.Remove(item);
    
        }

        public override IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }
        public override void Complete(TodoItem item)
        {
            item.Completed = true;
        }
        public override void Uncomplete(TodoItem item)
        {
            item.Completed = false;
        }


    }
}

using Microsoft.EntityFrameworkCore;

public interface ITodoService
{
    Task<List<TodoItem>> GetTodos();
    Task AddTodo(TodoItem todo);
    // ... other CRUD methods for TodoItem
}
public class TodoService : ITodoService {
    private readonly TodoDbContext _context;

    public TodoService(TodoDbContext context){
        _context = context;
    }

    public async Task<List<TodoItem>> GetTodos(){
        return await _context.TodoItems.ToListAsync();
    }

    public async Task AddTodo(TodoItem todo){
        _context.TodoItems.Add(todo);
        await _context.SaveChangesAsync();
    }
}

// ========================================
// 2. Services/ITodoService.cs
// ========================================
using System.Collections.Generic;
using Todo.Models;

namespace Todo.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetAllTodos();
        void AddTodo(TodoItem todo);
        void UpdateTodo(TodoItem todo);
        void DeleteTodo(int id);
        TodoItem GetTodoById(int id);
    }
}

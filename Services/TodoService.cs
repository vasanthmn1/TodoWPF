// ========================================
// 3. Services/TodoService.cs
// ========================================
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Models;

namespace Todo.Services
{
    public class TodoService : ITodoService
    {
        private List<TodoItem> _todos;
        private int _nextId;

        public TodoService()
        {
            _todos = new List<TodoItem>();
            _nextId = 1;
        }

        public List<TodoItem> GetAllTodos()
        {
            return new List<TodoItem>(_todos);
        }

        public void AddTodo(TodoItem todo)
        {
            todo.Id = _nextId++;
            todo.CreatedDate = DateTime.Now;
            _todos.Add(todo);
        }

        public void UpdateTodo(TodoItem todo)
        {
            var existingTodo = _todos.FirstOrDefault(t => t.Id == todo.Id);
            if (existingTodo != null)
            {
                existingTodo.Title = todo.Title;
                existingTodo.Description = todo.Description;
                existingTodo.IsCompleted = todo.IsCompleted;
            }
        }

        public void DeleteTodo(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
        }

        public TodoItem GetTodoById(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }
    }
}

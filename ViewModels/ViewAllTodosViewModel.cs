
// ========================================
// 10. ViewModels/ViewAllTodosViewModel.cs
// ========================================
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Todo.Models;
using Todo.Services;

namespace Todo.ViewModels
{
    public class ViewAllTodosViewModel : BaseViewModel
    {
        //private readonly ITodoService _todoService;
        //private ObservableCollection<TodoItem> _todos;

        //public ViewAllTodosViewModel()
        //{
        //    _todoService = App.TodoService;
        //    Todos = new ObservableCollection<TodoItem>(_todoService.GetAllTodos());

        //    DeleteTodoCommand = new RelayCommand(DeleteTodo);
        //    ToggleCompleteCommand = new RelayCommand(ToggleComplete);
        //    RefreshCommand = new RelayCommand(_ => LoadTodos());
        //}

        //public ObservableCollection<TodoItem> Todos
        //{
        //    get => _todos;
        //    set
        //    {
        //        _todos = value;
        //        OnPropertyChanged(nameof(Todos));
        //    }
        //}

        //public RelayCommand DeleteTodoCommand { get; }
        //public RelayCommand ToggleCompleteCommand { get; }
        //public RelayCommand RefreshCommand { get; }

        //private void LoadTodos()
        //{
        //    Todos = new ObservableCollection<TodoItem>(_todoService.GetAllTodos());
        //}

        //private void DeleteTodo(object parameter)
        //{
        //    if (parameter is TodoItem todo)
        //    {
        //        var result = MessageBox.Show($"Are you sure you want to delete '{todo.Title}'?",
        //            "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);

        //        if (result == MessageBoxResult.Yes)
        //        {
        //            _todoService.DeleteTodo(todo.Id);
        //            LoadTodos();
        //        }
        //    }
        //}

        //private void ToggleComplete(object parameter)
        //{
        //    if (parameter is TodoItem todo)
        //    {
        //        todo.IsCompleted = !todo.IsCompleted;
        //        _todoService.UpdateTodo(todo);
        //    }
        //}
    }
}

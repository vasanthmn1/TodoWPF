// ========================================
// 9. ViewModels/AddTodoViewModel.cs
// ========================================
using System.Windows;
using Todo.Models;
using Todo.Services;

namespace Todo.ViewModels
{
    public class AddTodoViewModel : BaseViewModel
    {
        private readonly ITodoService _todoService;
        private string _title;
        private string _description;

        //    public AddTodoViewModel()
        //    {
        //        _todoService = App.TodoService;
        //        AddTodoCommand = new RelayCommand(_ => AddTodo(), _ => CanAddTodo());
        //    }

        //    public string Title
        //    {
        //        get => _title;
        //        set
        //        {
        //            _title = value;
        //            OnPropertyChanged(nameof(Title));
        //        }
        //    }

        //    public string Description
        //    {
        //        get => _description;
        //        set
        //        {
        //            _description = value;
        //            OnPropertyChanged(nameof(Description));
        //        }
        //    }

        //    public RelayCommand AddTodoCommand { get; }

        //    private bool CanAddTodo()
        //    {
        //        return !string.IsNullOrWhiteSpace(Title);
        //    }

        //    private void AddTodo()
        //    {
        //        var newTodo = new TodoItem
        //        {
        //            Title = Title,
        //            Description = Description,
        //            IsCompleted = false
        //        };

        //        _todoService.AddTodo(newTodo);
        //        MessageBox.Show("Todo added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        //        Title = string.Empty;
        //        Description = string.Empty;
        //    }
    }
}

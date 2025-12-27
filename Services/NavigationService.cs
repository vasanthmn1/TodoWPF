// ========================================
// 5. Services/NavigationService.cs
// ========================================
using System;
using System.Windows.Controls;
using Todo.Views;

namespace Todo.Services
{
    public class NavigationService : INavigationService
    {
        private Frame _mainFrame;

        public Frame MainFrame
        {
            get => _mainFrame;
            set => _mainFrame = value;
        }

        public void NavigateTo(string pageName)
        {
            if (_mainFrame == null) return;

            Page page = pageName switch
            {
                "AddTodo" => new AddTodoPage(),
                "ViewAll" => new ViewAllTodosPage(),
                _ => new AddTodoPage()
            };

            _mainFrame.Navigate(page);
        }
    }
}

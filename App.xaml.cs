// ========================================
// 11. App.xaml.cs
// ========================================
using System.Windows;
using Todo.Services;

namespace Todo
{
    public partial class App : Application
    {
        public static ITodoService TodoService { get; private set; }
        public static INavigationService NavigationService { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            TodoService = new TodoService();
            NavigationService = new NavigationService();
        }
    }
}
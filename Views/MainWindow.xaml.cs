// ========================================
// 13. Views/MainWindow.xaml.cs
// ========================================
using System.Windows;
using Todo.ViewModels;

namespace Todo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.NavigationService.MainFrame = MainFrame;
            DataContext = new MainViewModel(App.NavigationService);

            App.NavigationService.NavigateTo("AddTodo");
        }
    }
}
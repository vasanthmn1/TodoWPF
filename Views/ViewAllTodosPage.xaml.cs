// ========================================
// 17. Views/ViewAllTodosPage.xaml.cs
// ========================================
using System.Windows.Controls;
using Todo.ViewModels;

namespace Todo.Views
{
    public partial class ViewAllTodosPage : Page
    {
        public ViewAllTodosPage()
        {
            InitializeComponent();
            DataContext = new ViewAllTodosViewModel();
        }
    }
}
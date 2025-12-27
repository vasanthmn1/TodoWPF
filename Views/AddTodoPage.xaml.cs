// ========================================
// 15. Views/AddTodoPage.xaml.cs
// ========================================
using System.Windows.Controls;
using Todo.ViewModels;

namespace Todo.Views
{
    public partial class AddTodoPage : Page
    {
        public AddTodoPage()
        {
            InitializeComponent();
            DataContext = new AddTodoViewModel();
        }
    }
}

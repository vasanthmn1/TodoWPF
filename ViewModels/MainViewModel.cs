
// ========================================
// 8. ViewModels/MainViewModel.cs
// ========================================
using Todo.Services;

namespace Todo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToAddTodoCommand = new RelayCommand(_ => NavigateToAddTodo());
            NavigateToViewAllCommand = new RelayCommand(_ => NavigateToViewAll());
        }

        public RelayCommand NavigateToAddTodoCommand { get; }
        public RelayCommand NavigateToViewAllCommand { get; }

        private void NavigateToAddTodo()
        {
            _navigationService.NavigateTo("AddTodo");
        }

        private void NavigateToViewAll()
        {
            _navigationService.NavigateTo("ViewAll");
        }
    }
}
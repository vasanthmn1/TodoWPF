// ========================================
// 4. Services/INavigationService.cs
// ========================================
using System.Windows.Controls;

namespace Todo.Services
{
    public interface INavigationService
    {
        void NavigateTo(string pageName);
        Frame MainFrame { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Todo.ViewModels;
public class DummyViewModel : INotifyPropertyChanged
{
    private bool _isLoading = false;

    public bool IsLoading
    {
        get { return _isLoading; }
        set
        {
            if (_isLoading != value)
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }
    }

    public RelayCommand SubmitCommand { get; }

    //public YourViewModel()
    //{
    //    SubmitCommand = new RelayCommand(async () => await OnSubmit());
    //}

    //private async Task OnSubmit()
    //{
    //    IsLoading = true;
    //    try
    //    {
    //        // Call API
    //        await ApiService.PostAsync();
    //    }
    //    finally
    //    {
    //        IsLoading = false;
    //    }
    //}

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Todo.Models;

namespace Todo.Views
{
    public partial class MainWindow : Window
    {
        private List<TodoItem> _allTodos;
        private const int PageSize = 10;

        public MainWindow()
        {
            InitializeComponent();

            LoadDummyData();

            Pager.Initialize(totalCount: _allTodos.Count, pageLimit: PageSize);
            Pager.PageChanged += OnPageChanged;

            LoadPage(1);
        }

        private void LoadDummyData()
        {
            _allTodos = new List<TodoItem>();

            for (int i = 1; i <= 200; i++)
            {
                _allTodos.Add(new TodoItem
                {
                    Id = i,
                    Title = $"Todo {i}",
                    Description = $"Description {i}",
                    IsCompleted = i % 2 == 0,
                    CreatedDate = DateTime.Now.AddDays(-i)
                });
            }
        }

        private void OnPageChanged(int page)
        {
            LoadPage(page);
        }

        private void LoadPage(int page)
        {
            TodoList.ItemsSource = _allTodos
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}

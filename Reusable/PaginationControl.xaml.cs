using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Todo.Reusable
{
    public partial class PaginationControl : UserControl
    {
        public event Action<int> PageChanged;

        private int _currentPage = 1;
        private int _totalPages = 1;

        public int PageLimit { get; private set; }
        public int TotalCount { get; private set; }

        public PaginationControl()
        {
            InitializeComponent();
        }

        public void Initialize(int totalCount, int pageLimit)
        {
            TotalCount = totalCount;
            PageLimit = pageLimit;

            _totalPages = (int)Math.Ceiling((double)TotalCount / PageLimit);
            _currentPage = 1;

            RenderPages();
            UpdateButtons();
        }

        private void RenderPages()
        {
            PageItems.Items.Clear();

            for (int i = 1; i <= _totalPages; i++)
            {
                var btn = new Button
                {
                    Content = i.ToString(),
                    Margin = new Thickness(3),
                    //Padding = new Thickness(8, 4)
                };

                btn.Click += Page_Click;

                if (i == _currentPage)
                {
                    btn.Background = Brushes.Blue;
                    btn.Foreground = Brushes.White;
                }
                else
                {
                    btn.Background = Brushes.LightGray;
                    btn.Foreground = Brushes.Black;
                }

                PageItems.Items.Add(btn);
            }
        }

        private void UpdateButtons()
        {
            PrevBtn.IsEnabled = _currentPage > 1;
            NextBtn.IsEnabled = _currentPage < _totalPages;
        }

        private void Page_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = int.Parse(((Button)sender).Content.ToString());
            RenderPages();
            UpdateButtons();
            PageChanged?.Invoke(_currentPage);
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage <= 1) return;
            _currentPage--;
            RenderPages();
            UpdateButtons();
            PageChanged?.Invoke(_currentPage);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage >= _totalPages) return;
            _currentPage++;
            RenderPages();
            UpdateButtons();
            PageChanged?.Invoke(_currentPage);
        }
    }
}

using System.Collections.ObjectModel;
using System.Windows.Input;

namespace zh2_2023_2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Todo> TodoList { get; set; }
        public ICommand CountAsCommand { get; set; }
        private Todo _selectedTodo;
        public Todo SelectedTodo
        {
            get => _selectedTodo; 
            set
            {
                _selectedTodo = value;
                OnPropertyChanged();
            }
        }
        private int _countedAd;
        public int CountedAd
        {
            get => _countedAd; set
            {
                _countedAd = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            TodoList = new ObservableCollection<Todo>
            {
                new Todo{Name="Branch letrehozasa", Description="asd", IsDone=false},
                new Todo{Name="Feladatok feltoltese", Description="asd", IsDone=false},
                new Todo{Name="Pull request letregozasa", Description="asd", IsDone=false},
                new Todo{Name="Javitas a varokasra", Description="asd", IsDone=false}
            };
            CountAsCommand = new Command(async () => await CountAsAsync());
            BindingContext = this;
        }

        private async Task CountAsAsync()
        {
            await Task.Run(() =>
            {
                CountedAd = TodoList.Sum(t => t.Description.Count(d => d == 'A' || d == 'a'));
            });
        }
    }

}

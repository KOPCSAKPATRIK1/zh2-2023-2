using System.Collections.ObjectModel;
using System.Windows.Input;

namespace zh2_2023_2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Mountain> Mountains { get; set; }
        public ICommand ClearClimbedCommand { get; }
        private Mountain _selectedMountain;
        public Mountain SelectedMountain
        {
            get => _selectedMountain; set
            {
                if (_selectedMountain != value)
                {
                    _selectedMountain = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Mountains = new ObservableCollection<Mountain>
            {
                new Mountain { Name = "János-hegy", Height = 527 },
                new Mountain { Name = "Kis-Hárs-hegy", Height = 362 },
                new Mountain { Name = "Nagy-Hárs-hegy", Height = 454 },
                new Mountain { Name = "Hármashatár-hegy", Height = 495 }
            };
            ClearClimbedCommand = new Command(ClearClimbed);
            BindingContext = this;
        }

        private void ClearClimbed()
        {
            foreach (Mountain m in Mountains)
            {
                m.Climbed = false;
            }
        }
    }

}

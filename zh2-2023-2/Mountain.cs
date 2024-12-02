using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zh2_2023_2
{
    public class Mountain : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Height { get; set; }
        private bool _climbed;
        public bool Climbed
        {
            get => _climbed; 
            set
            {
                if (_climbed != value)
                {
                    _climbed = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Climbed"));
        }
    }
}

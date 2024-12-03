using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zh2_2023_2
{
    public class Todo : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private bool _isDone;
        public string Name
        {
            get => _name; set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => _description; set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        public bool IsDone
        {
            get => _isDone; set
            {
                _isDone = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

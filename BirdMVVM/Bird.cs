using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BirdMVVM
{
    class Bird : INotifyPropertyChanged
    {
        private bool _isSelected;
        public string Name { get; set; }
        public string Url { get; set; }

        public Bird(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }
    }
}

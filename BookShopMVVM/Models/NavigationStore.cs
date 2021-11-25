using BookShopMVVM.ViewModels;
using System.ComponentModel;

namespace BookShopMVVM.Models
{
    public class NavigationStore : INotifyPropertyChanged
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentViewModel)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

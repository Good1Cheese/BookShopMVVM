using BookShopMVVM.Models;
using BookShopMVVM.ViewModels;
using System;
using System.Windows.Input;

namespace BookShopMVVM.Commands
{
    public class NavigationCommand : ICommand
    {
        private readonly NavigationStore _navigationStore;
        private readonly ViewModelBase _viewModelBase;

        public event EventHandler CanExecuteChanged;

        public NavigationCommand(NavigationStore navigationStore, ViewModelBase viewModelBase)
        {
            _navigationStore = navigationStore;
            _viewModelBase = viewModelBase;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _viewModelBase;
        }
    }
}

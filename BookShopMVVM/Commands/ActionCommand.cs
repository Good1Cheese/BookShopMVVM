using System;
using System.Windows.Input;

namespace BookShopMVVM.Commands
{
    public class ActionCommand : ICommand
    {
        private readonly Action<object> _action;

        public event EventHandler CanExecuteChanged;

        public ActionCommand(Action<object> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action.Invoke(parameter);
        }
    }
}
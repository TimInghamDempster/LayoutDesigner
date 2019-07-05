using System;
using System.Windows.Input;

namespace WPFUtils
{
    public class MyCommand : ICommand
    {
        Func<bool> _canExecute;
        Action _execute;

        public event EventHandler CanExecuteChanged;

        public MyCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ??
                throw new ArgumentNullException(nameof(execute));

            _canExecute = canExecute ??
                new Func<bool>(()=>true);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public bool CanExecute(object parameter) => _canExecute();

        public void Execute(object parameter) { _execute(); }
    }
}

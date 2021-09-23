using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreAdmin.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> _execute { get; set; }
        private Predicate<object> _canExecute { get; set; }

        public RelayCommand(Action<object> execute,Predicate<object> canExecute = null)
        {
            if(execute == null)
            {
                throw new NullReferenceException("NULLLLL");
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}

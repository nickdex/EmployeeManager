using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManager.Commands
{
    public class DelegateCommand : ICommand
    {
        Predicate<object> _predicate;

        Action<object> _action;

        public DelegateCommand(Predicate<object> predicate, Action<object> action)
        {
            _predicate = predicate;
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return _predicate(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestTaskRS.Common
{
    class Command : ICommand
    {
        private Action _action;

        public Command(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) //ignore for now
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged; //ignore for now
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UserInterface.Commands
{
    /// <summary>
    /// Abstract Class used as a base for every other command(not counting the async ones)
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter);
        protected virtual void OnCanExecuteChanged() 
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}

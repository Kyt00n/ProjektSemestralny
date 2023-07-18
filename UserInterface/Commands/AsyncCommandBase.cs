using System;
using System.Threading.Tasks;

namespace UserInterface.Commands
{
    /// <summary>
    /// Async abstract class that asynchronous command classes are based on.
    /// </summary>
    public abstract class AsyncCommandBase : CommandBase
    {
        public override async void Execute(object? parameter)
        {
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception ex) { }
        }
        public abstract Task ExecuteAsync(object parameter);
    }
}

using System;
using System.Threading.Tasks;
using UserInterface.Stores;

namespace UserInterface.Commands
{
    /// <summary>
    /// Read functionality for CRUD application.
    /// </summary>
    public class LoadTasks : AsyncCommandBase
    {
        private readonly TasksStore _tasksStore;

        public LoadTasks(TasksStore tasksStore)
        {
            _tasksStore = tasksStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _tasksStore.LoadTasks();
            }catch (Exception ex) { }
        }
    }
}

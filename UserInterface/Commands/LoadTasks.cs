using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Stores;

namespace UserInterface.Commands
{
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

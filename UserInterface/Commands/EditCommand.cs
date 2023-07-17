using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    public class EditCommand : AsyncCommandBase
    {
        private readonly EditTaskViewModel editTaskViewModel;
        private readonly TasksStore ts;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditCommand(EditTaskViewModel editCommand, TasksStore ts, ModalNavigationStore modalNavigationStore)
        {
            this.editTaskViewModel = editCommand;
            this.ts = ts;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            var formTask = editTaskViewModel.FormViewModel;
            TaskModel tm = new TaskModel(editTaskViewModel.TaskId, formTask.TaskName, formTask.Description, formTask.Priority, formTask.Location);
            try
            {
                await ts.Edit(tm);
                _modalNavigationStore.CurrentViewModel = null;
            }
            catch (Exception) { }
        }
    }
}

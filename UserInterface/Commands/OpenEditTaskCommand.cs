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
    public class OpenEditTaskCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TaskModel _taskModel;
        public OpenEditTaskCommand(TaskModel taskModel, ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _taskModel = taskModel;
        }

        public override void Execute(object? parameter)
        {
            EditTaskViewModel editTaskViewModel = new EditTaskViewModel(_taskModel, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editTaskViewModel;
        }
    }
}

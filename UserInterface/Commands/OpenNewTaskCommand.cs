using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    public class OpenNewTaskCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenNewTaskCommand(ModalNavigationStore modalNavigationStore, TasksStore tasksStore)
        {
            _modalNavigationStore = modalNavigationStore;
            TasksStore = tasksStore;
        }

        public TasksStore TasksStore { get; }

        public override void Execute(object? parameter)
        {
            AddNewTaskViewModel addNewTaskViewModel = new AddNewTaskViewModel(_modalNavigationStore, TasksStore);
            _modalNavigationStore.CurrentViewModel = addNewTaskViewModel;
        }
    }
}

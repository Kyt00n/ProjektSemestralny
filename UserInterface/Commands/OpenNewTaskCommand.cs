using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    /// <summary>
    /// Opens Modal(edit and create form page)
    /// </summary>
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

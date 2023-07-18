using BackEnd.Models;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.Commands
{
    /// <summary>
    /// Opens Modal(edit and create form page)
    /// </summary>
    public class OpenEditTaskCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TaskModel _taskModel;
        private ListingViewItem listingViewItem;
        private TaskModel taskmodel;
        private TasksStore tasksStore;

        public OpenEditTaskCommand(TaskModel taskModel, ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _taskModel = taskModel;
        }

        public OpenEditTaskCommand(ListingViewItem listingViewItem, TasksStore tasksStore, ModalNavigationStore modalNavigationStore)
        {
            this.listingViewItem = listingViewItem;
            this.tasksStore = tasksStore;
            this._modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            TaskModel tm = listingViewItem.Taskmodel;
            EditTaskViewModel editTaskViewModel = new EditTaskViewModel(tm,tasksStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editTaskViewModel;
        }
    }
}

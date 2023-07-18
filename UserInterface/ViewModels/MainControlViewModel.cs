using System.Windows.Input;
using UserInterface.Commands;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class MainControlViewModel : ViewModelBase
    {
        public ListingViewModel ListingViewModel { get; }
        public DescriptionsViewModel DescriptionsViewModel { get; }

        public ICommand NewTaskCommand { get; }

        public MainControlViewModel(SelectedTaskStore selectedTaskStore, ModalNavigationStore modalNavigationStore, TasksStore tasksStore)
        {
            
            ListingViewModel = ListingViewModel.LoadViewModel(selectedTaskStore, modalNavigationStore, tasksStore);
            DescriptionsViewModel = new DescriptionsViewModel(selectedTaskStore);
            NewTaskCommand = new OpenNewTaskCommand(modalNavigationStore, tasksStore);
        }
    }
}

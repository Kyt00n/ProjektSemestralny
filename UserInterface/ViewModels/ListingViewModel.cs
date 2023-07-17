using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Commands;
using UserInterface.Models;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class ListingViewModel : ViewModelBase
    {
        private SelectedTaskStore _selectedTaskStore { get; }
        private readonly ObservableCollection<ListingViewItem> _listingViewItems;
        private readonly ModalNavigationStore modalNavigationStore;
        private readonly TasksStore tasksStore;

        public IEnumerable<ListingViewItem> ListingViewItems => _listingViewItems;
        private ListingViewItem _selectedTaskItemViewModel;
        public ListingViewItem SelectedTaskItemViewModel
        {
            get => _selectedTaskItemViewModel;
            set
            {
                _selectedTaskItemViewModel = value;
                OnPropertyChanged(nameof(SelectedTaskItemViewModel));

                _selectedTaskStore.SelectedTaskModel = _selectedTaskItemViewModel?.Taskmodel;
            }
        }

        

        public ListingViewModel(SelectedTaskStore selectedTaskStore, ModalNavigationStore modalNavigationStore, TasksStore tasksStore)
        {
            _listingViewItems = new ObservableCollection<ListingViewItem>();
            
            
            _selectedTaskStore = selectedTaskStore;
            this.modalNavigationStore = modalNavigationStore;
            this.tasksStore = tasksStore;
            tasksStore.TaskAdded += TasksStore_TaskAdded;
        }

        private void TasksStore_TaskAdded(TaskModel obj)
        {
            AddItem(obj, modalNavigationStore);
        }

        private void AddItem(TaskModel task, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditTaskCommand(task, modalNavigationStore);
            _listingViewItems.Add(new ListingViewItem(task, editCommand));
        }
    }
}

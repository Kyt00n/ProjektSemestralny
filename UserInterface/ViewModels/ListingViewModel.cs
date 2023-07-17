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

        

        public ListingViewModel(SelectedTaskStore selectedTaskStore, ModalNavigationStore modalNavigationStore)
        {
            _listingViewItems = new ObservableCollection<ListingViewItem>();

            AddItem(new TaskModel("task1", "Description1", "critical", "salon"), modalNavigationStore);
            AddItem(new TaskModel("task2", "Description2", "critical", "salon"), modalNavigationStore);
            AddItem(new TaskModel("task3", "Description3", "critical", "salon"), modalNavigationStore);
            
            _selectedTaskStore = selectedTaskStore;
        }
        private void AddItem(TaskModel task, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditTaskCommand(task, modalNavigationStore);
            _listingViewItems.Add(new ListingViewItem(task, editCommand));
        }
    }
}

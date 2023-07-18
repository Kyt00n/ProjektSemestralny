
using BackEnd.Models;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    /// <summary>
    /// View model for Description window. Shows more information about selected task. 
    /// </summary>
    public class DescriptionsViewModel : ViewModelBase
    {
        public bool HasSelectedTask => SelectedTask != null;
        public string Task => SelectedTaskStore.SelectedTaskModel?.TaskName ?? "Not Found";
        public string DescriptionDisplay => SelectedTaskStore.SelectedTaskModel?.TaskDescription ?? "Not Found";
        public string PriorityDisplay => SelectedTaskStore.SelectedTaskModel?.TaskPriority ?? "Not Found";
        public string LocationDisplay => SelectedTaskStore.SelectedTaskModel?.TaskLocation ?? "Not Found";
        public SelectedTaskStore SelectedTaskStore { get; }
        private TaskModel SelectedTask => SelectedTaskStore.SelectedTaskModel;

        public DescriptionsViewModel(SelectedTaskStore selectedTaskStore)
        {
            SelectedTaskStore = selectedTaskStore;

            SelectedTaskStore.SelectedTaskChanged += SelectedTaskStore_SelectedTaskChanged;
        }
        protected override void Dispose()
        {
            SelectedTaskStore.SelectedTaskChanged -= SelectedTaskStore_SelectedTaskChanged;
        }

        private void SelectedTaskStore_SelectedTaskChanged()
        {
            OnPropertyChanged(nameof(Task));
            OnPropertyChanged(nameof(HasSelectedTask));
            OnPropertyChanged(nameof(DescriptionDisplay));
            OnPropertyChanged(nameof(PriorityDisplay));
            OnPropertyChanged(nameof(LocationDisplay));
        }
    }
}

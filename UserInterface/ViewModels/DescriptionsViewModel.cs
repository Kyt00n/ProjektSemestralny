using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class DescriptionsViewModel : ViewModelBase
    {
        public string Task => SelectedTaskStore.SelectedTaskModel?.TaskName;
        public string DescriptionDisplay => SelectedTaskStore.SelectedTaskModel?.TaskDescription;
        public string PriorityDisplay => SelectedTaskStore.SelectedTaskModel?.TaskPriority;
        public string LocationDisplay => SelectedTaskStore.SelectedTaskModel?.TaskLocation;
        public SelectedTaskStore SelectedTaskStore { get; }

        public DescriptionsViewModel(SelectedTaskStore selectedTaskStore)
        {
            SelectedTaskStore = selectedTaskStore;
        }
    }
}

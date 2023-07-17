using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Commands;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    public class AddNewTaskViewModel:ViewModelBase
    {
        private readonly TasksStore tasksStore;

        public FormViewModel FormViewModel { get;  }
        public AddNewTaskViewModel(ModalNavigationStore modalNavigationStore, TasksStore tasksStore)
        {
            FormViewModel = new FormViewModel(new SubmitCommand(this, modalNavigationStore, tasksStore), new CloseModalCommand(modalNavigationStore));
            this.tasksStore = tasksStore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Commands;
using UserInterface.Models;
using UserInterface.Stores;
using UserInterface.ViewModels;

namespace UserInterface.ViewModels
{
    public class EditTaskViewModel:ViewModelBase
    {
        public FormViewModel FormViewModel { get; }
        public EditTaskViewModel(TaskModel taskModel, ModalNavigationStore modalNavigationStore)
        {
            FormViewModel = new FormViewModel(null, new CloseModalCommand(modalNavigationStore))
            {
                TaskName = taskModel.TaskName,
                Description = taskModel.TaskDescription,
                Priority= taskModel.TaskPriority,
                Location = taskModel.TaskLocation
            };
        }
    }
}
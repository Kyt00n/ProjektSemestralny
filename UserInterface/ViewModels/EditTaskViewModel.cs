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
        public Guid TaskId { get; }
        public FormViewModel FormViewModel { get; }
        public EditTaskViewModel(TaskModel taskModel,TasksStore ts, ModalNavigationStore modalNavigationStore)
        {
            TaskId = taskModel.Id;
            FormViewModel = new FormViewModel(new EditCommand(this, ts, modalNavigationStore), new CloseModalCommand(modalNavigationStore))
            {
                TaskName = taskModel.TaskName,
                Description = taskModel.TaskDescription,
                Priority= taskModel.TaskPriority,
                Location = taskModel.TaskLocation
            };
        }
    }
}
using System;
using UserInterface.Commands;
using BackEnd.Models;
using UserInterface.Stores;

namespace UserInterface.ViewModels
{
    /// <summary>
    /// View model for Update functionality of the CRUD app. 
    /// </summary>
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Commands;
using BackEnd.Models;
using BackEnd.Queries;

namespace UserInterface.Stores
{
    public class TasksStore
    {
        private readonly IAddTaskCommand addTaskCommand;
        private readonly IRemoveTaskCommand removeTaskCommand;
        private readonly IEditTaskCommand editTaskCommand;
        private readonly IGetAllTasksQuery query;

        public TasksStore(IAddTaskCommand addTaskCommand, IRemoveTaskCommand removeTaskCommand, IEditTaskCommand editTaskCommand, IGetAllTasksQuery query)
        {
            this.addTaskCommand = addTaskCommand;
            this.removeTaskCommand = removeTaskCommand;
            this.editTaskCommand = editTaskCommand;
            this.query = query;
        }

        public event Action<TaskModel> TaskAdded;
        public event Action<TaskModel> TaskEdited;

        public async Task Add(TaskModel model)
        {
            await addTaskCommand.Execute(model);
            TaskAdded?.Invoke(model);
        }
        public async Task Edit(TaskModel model)
        {
            await editTaskCommand.Execute(model);
            TaskEdited?.Invoke(model);
        }
    }
}

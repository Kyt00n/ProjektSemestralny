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
    /// <summary>
    /// Store which purpose is only to keep track of the tasks. The most important store in the app.
    /// </summary>
    public class TasksStore
    {
        private readonly IAddTaskCommand addTaskCommand;
        private readonly IRemoveTaskCommand removeTaskCommand;
        private readonly IEditTaskCommand editTaskCommand;
        private readonly IGetAllTasksQuery query;
        private readonly List<TaskModel> _tasks;

        public IEnumerable<TaskModel> Tasks => _tasks;
        public TasksStore(IAddTaskCommand addTaskCommand, IRemoveTaskCommand removeTaskCommand, IEditTaskCommand editTaskCommand, IGetAllTasksQuery query)
        {
            this.addTaskCommand = addTaskCommand;
            this.removeTaskCommand = removeTaskCommand;
            this.editTaskCommand = editTaskCommand;
            this.query = query;
            _tasks = new List<TaskModel>();
        }

        public event Action<TaskModel> TaskAdded;
        public event Action<TaskModel> TaskEdited;
        public event Action TasksLoaded;
        public event Action<Guid> TaskRemoved;

        public async Task LoadTasks()
        {
            IEnumerable<TaskModel> tasks = await query.Execute();
            _tasks.Clear();
            _tasks.AddRange(tasks);

            TasksLoaded?.Invoke();
        }
        public async Task Add(TaskModel model)
        {
            await addTaskCommand.Execute(model);
            _tasks.Add(model);
            TaskAdded?.Invoke(model);
        }
        public async Task Edit(TaskModel model)
        {
            await editTaskCommand.Execute(model);
            int index = _tasks.FindIndex(t => t.Id == model.Id);
            if (index == -1)
            {
                _tasks[index] = model;
            }
            else
            {
                _tasks.Add(model);
            }
            TaskEdited?.Invoke(model);
        }

        public async Task Remove(Guid id)
        {
            await removeTaskCommand.Execute(id);
            _tasks.RemoveAll(x => x.Id == id);
            TaskRemoved?.Invoke(id);
        }
    }
}

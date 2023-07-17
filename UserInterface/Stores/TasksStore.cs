using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Models;

namespace UserInterface.Stores
{
    public class TasksStore
    {
        public event Action<TaskModel> TaskAdded;
        public event Action<TaskModel> TaskEdited;

        public async Task Add(TaskModel model)
        {
            TaskAdded?.Invoke(model);
        }
        public async Task Edit(TaskModel model)
        {
            TaskEdited?.Invoke(model);
        }
    }
}

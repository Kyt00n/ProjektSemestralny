using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;

namespace UserInterface.Stores
{
    public class TasksStore
    {
        public event Action<TaskModel> TaskAdded;

        public async Task Add(TaskModel model)
        {
            TaskAdded?.Invoke(model);
        }
    }
}

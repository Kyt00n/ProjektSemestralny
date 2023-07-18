using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Models;

namespace UserInterface.Stores
{
    /// <summary>
    /// Keeps track of which task is selected so it can be highlighted and proper Details
    /// can be visible.
    /// </summary>
    public class SelectedTaskStore
    {
        private readonly TasksStore _tasksStore;

        public SelectedTaskStore(TasksStore tasksStore)
        {
            _tasksStore = tasksStore;
            _tasksStore.TaskEdited += _tasksStore_TaskEdited;
        }

        private void _tasksStore_TaskEdited(TaskModel obj)
        {
            if (obj.Id == SelectedTaskModel?.Id)
            {
                SelectedTaskModel = obj;
            }
        }

        private TaskModel _taskModel;
        public TaskModel SelectedTaskModel
        {
            get { return _taskModel; }
            set { 
                _taskModel = value;
                SelectedTaskChanged?.Invoke();
            }
        }

        public event Action SelectedTaskChanged;
    }
}

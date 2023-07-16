using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;

namespace UserInterface.Stores
{
    public class SelectedTaskStore
    {
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
